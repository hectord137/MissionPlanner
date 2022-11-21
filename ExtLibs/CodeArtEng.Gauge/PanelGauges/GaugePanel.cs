using System;
using System.Collections.Generic;
using System.Linq;
using System.Drawing;
using System.Drawing.Design;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.ComponentModel;
using CodeArtEng.Gauge.Themes;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Container for collection of Panel Gauge Commponents
    /// </summary>
    public class GaugePanel : Panel
    {
        /// <summary>
        /// Override <see cref="Component.DesignMode"/> which does not works properly.
        /// </summary>
        protected new bool DesignMode { get => Application.ExecutablePath.ToLower().Contains("devenv"); }

        protected PanelGaugeComponentBase[] GaugeComponents
        {
            get => Controls.Cast<Control>().Where(x => x is PanelGaugeComponentBase)
                .Cast<PanelGaugeComponentBase>().Reverse().ToArray();
        }

        public GaugePanel()
        {
            BackColor = Color.FromKnownColor(KnownColor.ControlLight);
            Init();

            AnimationTimer = new Timer();
            AnimationTimer.Interval = AnimationUpdateInterval;
            AnimationTimer.Tick += AnimationTimer_Tick;
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        public override void Refresh()
        {
            base.Refresh();
            if (DesignMode)
            {
                foreach (PanelGaugeComponentBase c in GaugeComponents)
                    c.Refresh();
            }
        }

        private void Init()
        {
            this.SuspendLayout();
            ThemeData = ThemeManager.GetTheme(_Theme = GaugeTheme.Light);
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            if (DesignMode)
            {
                foreach (GaugeData d in GaugeDatas)
                    d.Dispose();
                GaugeDatas.Clear();
            }
            base.Dispose(disposing);
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            if (DesignMode) return;
            InspectGaugeDatas();

            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.GammaCorrected;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Evaluate Color based on assigned GaugeData
            ThemeColors themeColors;
            GaugeThemeBase theme;
            foreach (PanelGaugeComponentBase c in GaugeComponents)
            {
                if (!Enabled)
                {
                    theme = null;
                    themeColors = c.IsDarkTheme ? ThemeManager.DisabledDark : ThemeManager.DisabledLight;
                }
                else
                {
                    theme = (c.Theme == GaugeTheme.NotDefined) ? ThemeData : c.ThemeData;
                    themeColors = theme.Colors(c.DrawValueState());
                }
                GaugePaintEventArgs eventArg = new GaugePaintEventArgs(e, theme, themeColors);

                c.PaintBackground(e);
                c.PaintComponent(new GaugePaintEventArgs(e, theme, themeColors));
            }
        }

        [DefaultValue(typeof(Color), "ControlLight")]
        public override Color BackColor { get => base.BackColor; set => base.BackColor = value; }

        /// <summary>
        /// Reset gauge value and demo flag.
        /// </summary>
        public void Reset()
        {
            Demo = false;
            foreach (GaugeData d in GaugeDatas) d.Value = 0;
        }

        #region [ Gauge Appearance ]

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GaugeThemeBase UserDefinedColors { get; set; } = GaugeThemeBase.Default;

        /// <summary>
        /// Gauge Theme Parent Properties.
        /// </summary>
        [Category("Gauge Appearance")]
        [Description("Theme")]
        [DefaultValue(typeof(GaugeTheme), "Light")]
        public GaugeTheme Theme
        {
            get => _Theme;
            set
            {
                if (_Theme == value) return;
                _Theme = value;
                if (_Theme == GaugeTheme.NotDefined)
#if Freeware
                    _Theme = GaugeTheme.Light;
#else
                    _Theme = GaugeTheme.UserDefined;

                if (_Theme == GaugeTheme.UserDefined)
                {
                    UserDefinedColors = new DefaultTheme(ThemeData, this);
                    ThemeData = UserDefinedColors;
                }
                else
#endif
                    ThemeData = ThemeManager.GetTheme(value);
                Refresh();
            }
        }
        private GaugeTheme _Theme;
        internal GaugeThemeBase ThemeData;

#if !Freeware

        [Category("Gauge Appearance")]
        public ThemeColors BaseColors
        {
            get
            {
                if (Theme != GaugeTheme.UserDefined) return null;
                return UserDefinedColors.Base;
            }
        }

        [Category("Gauge Appearance")]
        public ThemeColors WarningColors
        {
            get
            {
                if (Theme != GaugeTheme.UserDefined) return null;
                return UserDefinedColors.Warning;
            }
        }
        [Category("Gauge Appearance")]
        public ThemeColors ErrorColors
        {
            get
            {
                if (Theme != GaugeTheme.UserDefined) return null;
                return UserDefinedColors.Error;
            }
        }

#endif
        #endregion

        #region [ Gauge Data ]

        [Category("Data")]
        [Description("Collection of GaugeData object assigned to this panel.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        [Editor(typeof(GaugeDataCollectionEditor), typeof(UITypeEditor))]
        /// <summary>
        /// List of data assigned to this panel.
        /// </summary>
        public List<GaugeData> GaugeDatas { get; set; } = new List<GaugeData>();

        private List<GaugeData> GaugeDatasInt = new List<GaugeData>();

        private void InspectGaugeDatas()
        {
            //Equality Check - Check any element diff bewtween 2 list.
            if (!GaugeDatas.Except(GaugeDatasInt).Any() && !GaugeDatasInt.Except(GaugeDatas).Any()) return;

            //List Different - Update
            foreach (GaugeData d in GaugeDatas)
                d.ClearValueAndPropertyChangedEventHandlers();

            GaugeDatasInt.Clear();
            GaugeDatasInt.AddRange(GaugeDatas);

            foreach (GaugeData d in GaugeDatasInt)
            {
                d.ClearValueAndPropertyChangedEventHandlers();
                d.ValueChanged += PanelGaugeData_ValueChanged;
                d.PropertyChanged += PanelGaugeData_PropertyChanged;
            }
        }

        private void GaugeDatasCollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        {
            foreach (GaugeData d in e.OldItems)
                d.ClearValueAndPropertyChangedEventHandlers();

            foreach (GaugeData d in e.NewItems)
            {
                d.ClearValueAndPropertyChangedEventHandlers();
                d.ValueChanged += PanelGaugeData_ValueChanged;
                d.PropertyChanged += PanelGaugeData_PropertyChanged;
            }
        }

        private void PanelGaugeData_PropertyChanged(object sender, EventArgs e)
        {
            Refresh();
        }

        private void PanelGaugeData_ValueChanged(object sender, EventArgs e)
        {
            if (this.InvokeRequired)
            {
                BeginInvoke(new Action<object, EventArgs>(PanelGaugeData_ValueChanged), sender, e);
                return;
            }

            //Notify respective gauge on value changed
            GaugeBase[] gauges = GaugeComponents.Where(x => x.GaugeData == sender).ToArray();
            foreach (GaugeBase g in gauges) g.GaugeValueChangedDelegate?.Invoke();

            if (AnimationEnabled && !DesignMode && GaugeComponents.Any(x => x.AnimationEnabled))
                BeginAnimation();
            else
            {
                UpdateComponentsValueNoAnimation();
                Refresh();
            }
        }

        private void UpdateComponentsValueNoAnimation()
        {
            foreach (PanelGaugeComponentBase c in GaugeComponents)
            {
                c.DrawValue = c.Enabled ? c.Value : c.ResetValue;
                c.PeakUpdate();
            }
        }

        #endregion

        #region [ Gauge Animation ]

        [Description("Gauge demo mode. Enable this mode to trigger gauge to sweep from min to max and vice versa.")]
        [Category("Gauge Animation")]
        [DefaultValue(false)]
        public bool Demo
        {
            get => _Demo;
            set
            {
                _Demo = value;
                if (DesignMode) return;
                if (_Demo)
                {
                    foreach (GaugeData c in GaugeDatas)
                    {
                        c.Value = (c.Value == c.Maximum) ? c.Minimum : c.Maximum;
                    }
                }
            }
        }
        private bool _Demo = false;

        [Category("Gauge Animation")]
        [Description("Enable / Disable pointer and gauge value animation when value changed.")]
        [DefaultValue(true)]
        public bool AnimationEnabled { get; set; } = true;

        [Category("Gauge Animation")]
        [Description("Animation update interval in ms")]
        [DefaultValue(50)]
        public int AnimationUpdateInterval
        {
            get;
#if Freeware
            private
#endif
            set;
        } = 50;

        private readonly Timer AnimationTimer;

        protected void BeginAnimation()
        {
            AnimationTimer.Interval = AnimationUpdateInterval;
            AnimationTimer.Start();
        }

        private static Random RGen = new Random();
        private void AnimationTimer_Tick(object sender, System.EventArgs e)
        {
            if (!Enabled)
            {
                UpdateComponentsValueNoAnimation();
                Refresh();
                return;
            }

            int activeCount = 0;
            foreach (PanelGaugeComponentBase c in GaugeComponents)
            {
                if (!c.AnimationEnabled)
                {
                    //No animation - update immediately
                    c.DrawValue = c.Value;
                    continue;
                }

                //Animation Step
                if (c.DrawValue != c.Value)
                {
                    if (c.PointerSupportAnimation)
                    {
                        if (c.DrawValue < c.Value)
                        {
                            c.DrawValue = Math.Min(c.DrawValue + c.AnimationStep, c.Value);
                        }
                        else //Paint Value > Value
                        {
                            c.DrawValue = Math.Max(c.DrawValue - c.AnimationStep, c.Value);
                        }
                        if (c.DrawValue != c.Value) c.DrawValue = Math.Floor(c.DrawValue);
                    }
                    else { c.DrawValue = c.Value; }
                    c.PeakUpdate();
                    activeCount++;
                }
                else if (Demo)
                {
                    double newValue;
                    do
                    {
                        newValue= RGen.Next((int)c.Minimum, (int)c.Maximum);
                    } while (newValue == c.DrawValue);
                    c.Value = newValue;
                }
            }

            if (!Demo && (activeCount == 0))
            {
                AnimationTimer.Stop();
            }
            Refresh();

        }

        #endregion
    }
}
