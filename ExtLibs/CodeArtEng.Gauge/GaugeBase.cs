using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using System.Reflection;
using CodeArtEng.Gauge.Themes;
using System.Runtime.CompilerServices;
using CodeArtEng.Gauge.PanelGauges;
using System.Diagnostics.Eventing.Reader;
using Timer = System.Windows.Forms.Timer;

namespace CodeArtEng.Gauge
{
    public enum GaugeInfoMode
    {
        NONE,
        MouseOver,
        MouseClick
    }

    [Flags]
    public enum GaugeInfoType
    {
        Range = 1,
        Limits = 2,
    }

    public abstract class GaugeBase : UserControl
    {
        // DESIGN Constants
        protected const int AngleOffset = -90;

        #region [ Events ]

        /// <summary>
        /// Occur when value reached warning limit
        /// </summary>
        public event EventHandler WarningLimitReached;
        /// <summary>
        /// <see cref="WarningLimitReached"/> event handler.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnWarningLimitReached(EventArgs e) { WarningLimitReached?.Invoke(this, e); }

        /// <summary>
        /// Occur when value reached error limit
        /// </summary>
        public event EventHandler ErrorLimitReached;
        /// <summary>
        /// <see cref="ErrorLimitReached"/> event handler.
        /// </summary>
        /// <param name="e"></param>
        protected virtual void OnErrorLimitReached(EventArgs e) { ErrorLimitReached?.Invoke(this, e); }

        #endregion

        #region [ Delegate Callback ]

        internal delegate void GaugeValueChanged();
        internal GaugeValueChanged GaugeValueChangedDelegate = null;

        #endregion

        #region [ Override and Hide Properties ]

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public override Color ForeColor { get => base.ForeColor; set => base.ForeColor = value; }

        #endregion

        protected GaugeBase()
        {
            Init();

            AnimationTimer = new Timer();
            AnimationTimer.Interval = AnimationUpdateInterval;
            AnimationTimer.Tick += AnimationTimer_Tick;

            SetDrawingStyleStandaloneComponent();

            MouseEnter += GaugeBase_MouseEnter;
            MouseLeave += GaugeBase_MouseLeave;
            MouseClick += GaugeBase_MouseClick;

            AssignGaugeData(GaugeData.Default());
            DrawValue = Value;
        }

        private void Init()
        {
            this.SuspendLayout();
            ThemeData = ThemeManager.GetTheme(_Theme = GaugeTheme.Light);
            this.ResumeLayout(false);
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        #region [ Utility ]

        /// <summary>
        /// Override <see cref="Component.DesignMode"/> which does not works properly.
        /// </summary>
        protected new bool DesignMode { get => Application.ExecutablePath.ToLower().Contains("devenv"); }

        internal void SetValue<T>(ref T property, T value)
        {
            if (property != null)
            {
                if (property.Equals(value)) return;
            }
            property = value;
            Refresh();
        }

        internal void SetDrawingStyleStandaloneComponent()
        {
            SetStyle(ControlStyles.UserPaint, true);
            SetStyle(ControlStyles.AllPaintingInWmPaint, true);
            SetStyle(ControlStyles.OptimizedDoubleBuffer, true);
        }

        #endregion

        #region [ Gauge Info ]

        protected bool ShowGaugeInfo { get; private set; } = false;

        /// <summary>
        /// Gauge info display mode. No effect if derived class does not implement
        /// <see cref="DrawGaugeInfo(GaugePaintEventArgs, GaugeInfoType)"/>
        /// </summary>
        [Category("Gauge Info")]
        [DefaultValue(GaugeInfoMode.MouseOver)]
        [Description("Gauge info display mode.")]
        public GaugeInfoMode InfoMode { get; set; } = GaugeInfoMode.MouseOver;

        [Category("Gauge Info")]
        [Description("Select gauge info page to display.")]
        [DefaultValue(GaugeInfoType.Range | GaugeInfoType.Limits)]
        public GaugeInfoType InfoPage { get; set; } = GaugeInfoType.Range | GaugeInfoType.Limits;
        private GaugeInfoType ActivePage = GaugeInfoType.Range;

        private void GaugeBase_MouseClick(object sender, MouseEventArgs e)
        {
            if (InfoMode == GaugeInfoMode.MouseClick)
            {
                if (!e.Button.HasFlag(MouseButtons.Left)) return;
                NextInfoPage();
                Refresh();
            }
        }

        private void NextInfoPage()
        {
            if (!ShowGaugeInfo)
            {
                ActivePage = GaugeInfoType.Range;
                ShowGaugeInfo = true;
            }
            else
            {
                ActivePage = (GaugeInfoType)((int)ActivePage << 1);
            }

            while ((int)(ActivePage & InfoPage) == 0)
            {
                ActivePage = (GaugeInfoType)((int)ActivePage << 1);
                if ((int)ActivePage > (int)InfoPage)
                {
                    ShowGaugeInfo = false;
                    return;
                }
            }
        }

        private void GaugeBase_MouseLeave(object sender, EventArgs e)
        {
            if (InfoMode == GaugeInfoMode.MouseOver)
            {
                ShowGaugeInfo = false;
                Refresh();
            }
        }

        private void GaugeBase_MouseEnter(object sender, EventArgs e)
        {
            if (InfoMode == GaugeInfoMode.MouseOver)
            {
                NextInfoPage();
                Refresh();
            }
        }

        #endregion

        #region [ Gauge Painting ]

        protected override void OnPaint(PaintEventArgs e)
        {
            e.Graphics.InterpolationMode = InterpolationMode.HighQualityBilinear;
            e.Graphics.CompositingQuality = CompositingQuality.GammaCorrected;
            e.Graphics.PixelOffsetMode = PixelOffsetMode.HighSpeed;
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;

            //Assign Color based on value state
            try
            {
                this.SuspendLayout();
                ThemeColors themeColors;
                GaugeThemeBase theme = null;
                if (!Enabled)
                    themeColors = IsDarkTheme ? ThemeManager.DisabledDark : ThemeManager.DisabledLight;
                else
                {
                    theme = (ThemeData == null) ? UserDefinedColors : ThemeData;
                    themeColors = theme.Colors(DrawValueState());
                }
                GaugePaintEventArgs eventArg = new GaugePaintEventArgs(e, theme, themeColors);

                if (ShowGaugeInfo && IsGaugeInfoImplemented())
                    DrawGaugeInfo(eventArg, ActivePage);
                else OnPaintGauge(eventArg);
            }
            finally { this.ResumeLayout(); }
        }

        public bool IsGaugeInfoImplemented()
        {
            MethodInfo m = this.GetType().GetMethod(nameof(DrawGaugeInfo), BindingFlags.Instance | BindingFlags.NonPublic);
            if (m == null) return false;
            return m.GetBaseDefinition().DeclaringType != m.DeclaringType;
        }

        internal virtual void DrawGaugeInfo(GaugePaintEventArgs e, GaugeInfoType infoType) { }

        internal abstract void OnPaintGauge(GaugePaintEventArgs e);

        /// <summary>
        /// Return gauge state based on current <see cref="DrawValue"/>
        /// </summary>
        /// <returns></returns>
        internal GaugeValueState DrawValueState() { return ValueState(DrawValue); }

        /// <summary>
        /// Return gauge state based on given value.
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        internal GaugeValueState ValueState(double value)
        {
            GaugeValueState result = GaugeValueState.OK;
            if (IgnoreLimits) return result;

            if (Double.IsNaN(value)) return GaugeValueState.Error;

            if (WarningLimit != double.NaN)
            {
                if (InvertLimit)
                {
                    if (value <= WarningLimit) result = GaugeValueState.Warning;
                }
                else if (value >= WarningLimit) result = GaugeValueState.Warning;
            }
            if (ErrorLimit != double.NaN)
            {
                if (InvertLimit)
                {
                    if (value <= ErrorLimit) result = GaugeValueState.Error;
                }
                else if (value >= ErrorLimit) result = GaugeValueState.Error;
            }
            return result;

        }

        /// <summary>
        /// Value draw on gauge.
        /// </summary>
        internal double DrawValue { get; set; }

        protected string DrawValueStr { get => (DrawValue * ScaleFactor).ToString(ValueFormat); }

        /// <summary>
        /// Pointer value draw on gauge, limit within Minimum and Maximum.
        /// </summary>
        internal double PointerValue { get => Math.Max(Minimum, Math.Min(Maximum, DrawValue)); }

        /// <summary>
        /// Draw multiple line from given reference point
        /// </summary>
        /// <param name="e"></param>
        /// <param name="referencePoint"></param>
        /// <param name="lines"></param>
        /// <param name="alignment">(Default) Center.</param>
        internal void DrawMultiLines(GaugePaintEventArgs e, Point referencePoint, string[] lines, HorizontalAlignment alignment = HorizontalAlignment.Center)
        {
            SizeF textSize;
            Rectangle textRect;
            switch (lines.Length)
            {
                case 1:
                    textSize = e.Graphics.MeasureString(lines[0], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    TextRenderer.DrawText(e.Graphics, lines[0], FontUnitLabel, textRect, e.TextColor);
                    break;

                case 2:
                    textSize = e.Graphics.MeasureString(lines[0], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    textRect.Offset(0, -(int)(textSize.Height / 2));
                    TextRenderer.DrawText(e.Graphics, lines[0], FontUnitLabel, textRect, e.TextColor);

                    textSize = e.Graphics.MeasureString(lines[1], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    textRect.Offset(0, (int)(textSize.Height / 2));
                    TextRenderer.DrawText(e.Graphics, lines[1], FontUnitLabel, textRect, e.TextColor);
                    break;

                case 3:
                    textSize = e.Graphics.MeasureString(lines[0], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    textRect.Offset(0, -(int)textSize.Height);
                    TextRenderer.DrawText(e.Graphics, lines[0], FontUnitLabel, textRect, e.TextColor);

                    textSize = e.Graphics.MeasureString(lines[1], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    TextRenderer.DrawText(e.Graphics, lines[1], FontUnitLabel, textRect, e.TextColor);

                    textSize = e.Graphics.MeasureString(lines[2], FontUnitLabel);
                    textRect = DrawingEx.RectangleFromReference(referencePoint, (int)textSize.Width, (int)textSize.Height, alignment);
                    textRect.Offset(0, (int)(textSize.Height));
                    TextRenderer.DrawText(e.Graphics, lines[2], FontUnitLabel, textRect, e.TextColor);
                    break;

                default:
                    throw new NotSupportedException("Unable to handle text more than 3 lines!");
            }
        }

        #endregion

        #region [ Appearance ]

        /// <summary>
        /// Gauge Title
        /// </summary>
        [Category("Appearance")]
        [Description("Gauge Title")]
        [DefaultValue(null)]
        public string Title
        {
            get => _Title;
            set => SetValue(ref _Title, value);
        }
        private string _Title = string.Empty;

        /// <summary>
        /// Font used to display unit.
        /// </summary>
        [Category("Appearance")]
        [Description("Font for title.")]
        [DefaultValue(typeof(Font), "Microsoft Sans Serif, 8.25pt")]
        public Font FontTitle
        {
            get => _FontTitle;
            set => SetValue(ref _FontTitle, value);
        }
        private Font _FontTitle = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

        /// <summary>
        /// Font used to display unit.
        /// </summary>
        [Category("Appearance")]
        [Description("Font used to display unit.")]
        [DefaultValue(typeof(Font), "Microsoft Sans Serif, 8.25pt")]
        public Font FontUnitLabel
        {
            get => _FontUnitLabel;
            set => SetValue(ref _FontUnitLabel, value);
        }
        private Font _FontUnitLabel = new Font("Microsoft Sans Serif", (float)8.25, FontStyle.Regular);

        [Category("Appearance")]
        [Description("Value string display format")]
        [DefaultValue(null)]
        public string ValueFormat
        {
            get;
#if Freeware
            private
#endif
            set;
        } = null;

        [Category("Appearance")]
        [Description("Scale factor for pointer display value, where display string = Value x ScaleFactor.")]
        [DefaultValue(1)]
#if Freeware
        [Obsolete("WARNING: Setting this property has no effect in free version.")]
#endif
        public double ScaleFactor
        {
            get => _Factor;
            set
            {
#if Freeware

#else
                SetValue(ref _Factor, value);
#endif
            }
        }
        private double _Factor = 1;

        #endregion

        #region [ Gauge Appearance ]

        internal bool IsDarkTheme { get => (int)Theme >= 100; }

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
#if !Freeware
                if (_Theme == GaugeTheme.UserDefined)
                {
                    //Create user defined theme based on current color scheme
                    UserDefinedColors = new DefaultTheme(ThemeData);
                    ThemeData = UserDefinedColors;
                }
                else
#endif
                ThemeData = ThemeManager.GetTheme(value);
                Refresh();
            }
        }
        protected GaugeTheme _Theme;
        internal GaugeThemeBase ThemeData;

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public GaugeThemeBase UserDefinedColors { get; set; } = GaugeThemeBase.Default;

        [Category("Gauge Appearance")]
        [Description("Ignore warning and error limits in GaugeData, always use base color from theme.")]
        [DefaultValue(false)]
        public bool IgnoreLimits { get => _IgnoreLimits; set => SetValue(ref _IgnoreLimits, value); }
        private bool _IgnoreLimits = false;

#if !Freeware

        [Category("Gauge Appearance")]
        [Description("Base color for Gauge when gauge value below warning and error limit.")]
        public ThemeColors BaseColors
        {
            get
            {
                if (Theme != GaugeTheme.UserDefined) return null;
                return UserDefinedColors.Base;
            }
        }

        [Category("Gauge Appearance")]
        [Description("Color when gauge value goes beyond warining limit.")]
        public ThemeColors WarningColors
        {
            get
            {
                if (Theme != GaugeTheme.UserDefined) return null;
                return UserDefinedColors.Warning;
            }
        }

        [Category("Gauge Appearance")]
        [Description("Color when gauge value goes beyond error limit.")]
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

        [Category("Gauge Data")]
        [Description("Value when gauge is reset. Default value is 0.")]
        [DefaultValue(0)]
        public double ResetValue { get; set; } = 0;

        private bool SkipAnimation = false;

        /// <summary>
        /// Reset gauge to <see cref="ResetValue"/> and stop Demo mode.
        /// </summary>
        /// <param name="skipAnimation">Option to update gauge without animation even when <see cref="AnimationEnabled"/> is enabled.</param>
        public virtual void Reset(bool skipAnimation = true)
        {
#if Freeware
            throw new NotImplementedException();
#else
            SkipAnimation = skipAnimation;
            Demo = false;
            Value = ResetValue;
            SkipAnimation = false;
#endif
        }

        private GaugeData gaugeData = null;

        /// <summary>
        /// Object which define limits and value.
        /// </summary>
        public virtual GaugeData GaugeData
        {
            get => gaugeData;
            set => AssignGaugeData(value);
        }

        private void AssignGaugeData(GaugeData data)
        {
            if (gaugeData != null)
            {
                gaugeData.PropertyChanged -= GaugeData_PropertyChanged;
                gaugeData.ValueChanged -= GaugeData_ValueChanged;
            }

            gaugeData = data == null ? GaugeData.Default() : data;
            gaugeData.PropertyChanged += GaugeData_PropertyChanged;
            gaugeData.ValueChanged += GaugeData_ValueChanged;
            DrawValue = Value = gaugeData.Value;
            GaugeData_ValueChanged(gaugeData, null);
            Refresh();
        }

        /// <summary>
        /// Value changed event handler for standalone gauge.
        /// Refer <see cref="PanelGauges.GaugePanel.PanelGaugeData_ValueChanged(object, GaugeDataEventArgs)"/>
        /// for Panel Gauge component's value changed event 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void GaugeData_ValueChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<object, EventArgs>(GaugeData_ValueChanged), sender, e);
                return;
            }

            GaugeValueChangedDelegate?.Invoke();
            GaugeData ptrData = sender as GaugeData;
            if (ptrData == null) throw new ArgumentException("GaugeData_ValueChanged: Invalid sender object!");

            //Limit check, trigger event when crossed warning or error limit
            if (WarningLimit != double.NaN)
            {
                if (InvertLimit)
                {
                    if ((ptrData.OldValue > WarningLimit) && (ptrData.Value <= WarningLimit))
                        OnWarningLimitReached(EventArgs.Empty);
                }
                else
                {
                    //Value crossed warning limit
                    if ((ptrData.OldValue < WarningLimit) && (ptrData.Value >= WarningLimit))
                        OnWarningLimitReached(EventArgs.Empty);
                }
            }
            if (ErrorLimit != double.NaN)
            {
                if (InvertLimit)
                {
                    if ((ptrData.OldValue > ErrorLimit) && (ptrData.Value <= ErrorLimit))
                        OnErrorLimitReached(EventArgs.Empty);
                }
                else
                {
                    //Value crossed warning limit
                    if ((ptrData.OldValue < ErrorLimit) && (ptrData.Value >= ErrorLimit))
                        OnErrorLimitReached(EventArgs.Empty);
                }
            }

            if (AnimationEnabled && !DesignMode && !SkipAnimation) BeginAnimation();
            else
            {
                DrawValue = Enabled ? ptrData.Value : ResetValue;
                PeakUpdate();
                Refresh();
            }
        }

        private void GaugeData_PropertyChanged(object sender, EventArgs e)
        {
            if (InvokeRequired)
            {
                BeginInvoke(new Action<object, EventArgs>(GaugeData_PropertyChanged), sender, e);
                return;
            }
            Refresh();
        }

        /// <summary>
        /// Get or set minimum value of pointer.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Get or set minimum value of pointer.")]
        [DefaultValue(0.0)]
        public double Minimum
        {
            get => GaugeData.Minimum;
            set => GaugeData.Minimum = value;
        }

        /// <summary>
        /// Get or set maximum value of pointer.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Get or set maximum value of pointer.")]
        [DefaultValue(200.0)]
        public double Maximum
        {
            get => GaugeData.Maximum;
            set => GaugeData.Maximum = value;
        }

        /// <summary>
        /// Gauge value
        /// </summary>
        [Category("Gauge Data")]
        [DefaultValue(88.0)]
        [Description("Initial Gauge Value. Value can be smaller than minimum or larger than maximum.")]
        public double Value
        {
            get => GaugeData.Value;
            set => GaugeData.Value = value;
        }

        /// <summary>
        /// Unit Text.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Unit text, display below value in Gauge. Set to empty string to hide.")]
        public string Unit
        {
            get => GaugeData.Unit;
            set => GaugeData.Unit = value;
        }

        /// <summary>
        /// Change pointer to PointerWarningColor when value goes beyond warning limit. Set value to NAN to disable warning limit.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Change pointer to PointerWarningColor when value goes beyond warning limit. Set value to NAN to disable warning limit.")]
        [DefaultValue(120.0)]
        public double WarningLimit
        {
            get => GaugeData.WarningLimit;
            set => GaugeData.WarningLimit = value;
        }

        /// <summary>
        /// Change pointer to PointerErrorColor when value goes beyond error limit. Set value to NAN to disable error limit.
        /// </summary>
        [Category("Gauge Data")]
        [Description("Change pointer to PointerErrorColor when value goes beyond error limit. Set value to NAN to disable error limit.")]
        [DefaultValue(160.0)]
        public double ErrorLimit
        {
            get => GaugeData.ErrorLimit;
            set => GaugeData.ErrorLimit = value;
        }

        /// <summary>
        /// When enable, warning or error is triggered when value fall below limit.
        /// </summary>
        [Category("Gauge Data")]
        [Description("When enable, warning or error is triggered when value fall below limit.")]
        [DefaultValue(false)]
        public bool InvertLimit
        {
            get => GaugeData.InvertLimit;
            set => GaugeData.InvertLimit = value;
        }

        #endregion

        #region [ PEAK ]

        /// <summary>
        /// Peak Value 
        /// </summary>
        protected double Peak
        {
            get => _Peak;
            private set
            {
                _Peak = Math.Min(Maximum, Math.Max(Minimum, value));
                PeakLastUpdate = DateTime.Now;
                if (PeakHoldDuration > 0) StartPeakResetTimer();
            }
        }
        private double _Peak = double.MinValue;
        private Timer PeakResetTimer = null;
        private DateTime PeakLastUpdate = new DateTime();

        /// <summary>
        /// Define how long peak will be hold till next update. Value in seconds.
        /// </summary>
        [Category("Gauge Animation")]
        [Description("Define how long peak will be hold till next update. Value in seconds. 0 means never expired.")]
        [DefaultValue(0)]
        public int PeakHoldDuration
        {
            get => _PeakHoldDuration;
#if Freeware
            private
#endif
            set
            {
                if (value < 0) throw new ArgumentException("Value must be greater or equal than 0!");
                _PeakHoldDuration = value;

                if (value == 0) PeakResetTimer?.Stop();
                else if (PeakResetTimer != null) PeakResetTimer.Interval = value * 1000;
            }
        }
        private int _PeakHoldDuration = 0;

        [Category("Gauge Layout")]
        [Description("Display Peak Value. Only applicable for supported gauge.")]
        [DefaultValue(false)]
        public bool PeakVisible
        {
            get;
#if Freeware
            private
#endif
            set;
        } = false;

        /// <summary>
        /// Reset Peak
        /// </summary>
        public void PeakReset()
        {
#if Freeware
            throw new NotImplementedException();
#else
            Peak = Math.Min(Maximum, Math.Max(Minimum, Value));
            PeakResetTimer.Stop();
            Refresh();
#endif
        }

        private void PeakResetTimer_Tick(object sender, EventArgs e)
        {
            PeakReset();
        }

        private void StartPeakResetTimer()
        {
            if (PeakHoldDuration <= 0) return;
            if (PeakResetTimer == null)
            {
                PeakResetTimer = new Timer();
                PeakResetTimer.Tick += PeakResetTimer_Tick;
                PeakResetTimer.Interval = PeakHoldDuration * 1000;
            }
            PeakResetTimer.Start();
        }

        internal void PeakUpdate()
        {
            if (!PeakVisible) return;

            if (Peak < DrawValue)
            {
                Peak = DrawValue;
            }
            else if (PeakHoldDuration > 0)
            {
                if ((DateTime.Now - PeakLastUpdate).TotalSeconds > PeakHoldDuration)
                {
                    Peak = DrawValue;
                }
            }
            else if (DrawValue < Peak) StartPeakResetTimer();
        }

        #endregion

        #region [ Gauge Animation ]

        /// <summary>
        /// Define if pointer support animation using incremental <see cref="DrawValue"/> when 
        /// <see cref="AnimationEnabled"/> is set to true. Draw Value is updated in
        /// <see cref="AnimationTimer_Tick(object, EventArgs)"/> method.
        /// </summary>
        internal bool PointerSupportAnimation { get; set; } = true;

        /// <summary>
        /// Copy animation properties from another Gauge component.
        /// </summary>
        /// <param name="sender"></param>
        public void CopyAnimationProperties(GaugeBase sender)
        {
            if (sender == null) return;
            Demo = sender.Demo;
            AnimationEnabled = sender.AnimationEnabled;
            AnimationStep = sender.AnimationStep;
            AnimationUpdateInterval = sender.AnimationUpdateInterval;
        }

        /// <summary>
        /// Gauge demo mode. Enable this mode to trigger gauge to update gauge with random values.
        /// Demo mode required <see cref="AnimationEnabled"/> enabled to work.
        /// </summary>
        [Description("Gauge demo mode. Enable this mode to trigger gauge to update gauge with random values.")]
        [Category("Gauge Animation")]
        [DefaultValue(false)]
        public bool Demo
        {
            get => _Demo; set
            {
                _Demo = value;
                if (DesignMode) return;
                if (_Demo) Value = (Value == Maximum) ? Minimum : Maximum;
                else Value = DrawValue; //Stop Demo mode immediately
            }
        }
        private bool _Demo = false;

        /// <summary>
        /// Incremental steps during animation
        /// </summary>
        [Category("Gauge Animation")]
        [Description("Incremental steps for poiner value during animation")]
        [DefaultValue(5)]
        public int AnimationStep
        {
            get;
#if Freeware
            private
#endif
            set;
        } = 5;

        /// <summary>
        /// Animation update interval in ms
        /// </summary>
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

        /// <summary>
        /// Enable / Disable pointer and gauge value when value changed.
        /// </summary>
        [Category("Gauge Animation")]
        [Description("Enable / Disable pointer and gauge value animation when value changed.")]
        [DefaultValue(true)]
        public bool AnimationEnabled { get; set; } = true;

        /// <summary>
        /// Last value painted on control. Used for animation tracking
        /// </summary>
        private readonly Timer AnimationTimer;

        protected void BeginAnimation()
        {
            AnimationTimer.Interval = Math.Max(1, AnimationUpdateInterval);
            AnimationTimer.Start();
        }

        //ToDo: Decoupled Demo from Animation using another timer?
        // - How to control demo timer interval? Hard coded?

        private static Random RGen = new Random();
        private void AnimationTimer_Tick(object sender, EventArgs e)
        {
            if (!Enabled)
            {
                AnimationTimer.Stop();
                Demo = false;
                DrawValue = ResetValue;
                PeakUpdate();
                Refresh();
                return;
            }

            if (DrawValue != Value)
            {
                if (PointerSupportAnimation)
                {
                    if (DrawValue < Value)
                    {
                        DrawValue = Math.Min(DrawValue + AnimationStep, Value);
                    }
                    else //Paint Value > Value
                    {
                        DrawValue = Math.Max(DrawValue - AnimationStep, Value);
                    }
                    if (DrawValue != Value) DrawValue = Math.Floor(DrawValue);
                    PeakUpdate();
                }
                else { DrawValue = Value; }
                Refresh();
            }
            else
            {
                AnimationTimer.Stop();
                if (Demo)
                {
                    double newValue;
                    do
                    {
                        newValue = RGen.Next((int)Minimum, (int)Maximum);
                    } while (newValue == DrawValue);
                    Value = newValue;
                }
            }
        }

        #endregion

    }
}
