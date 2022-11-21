using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Threading.Tasks;
using CodeArtEng.Gauge;
using System.Windows.Forms;

namespace CodeArtEng.Gauge.PanelGauges
{
    public abstract partial class PanelGaugeComponentBase : GaugeBase
    {
        private bool IsDrawByPanel
        {
            get
            {
                if (Parent is GaugePanel p)
                {
                    if (DesignMode) return false;
                    else return true;
                }
                else return false;
            }
        }

        public new bool Visible { get; set; } = true;

        public PanelGaugeComponentBase() : base()
        {
            ParentChanged += PanelGaugeComponentBase_ParentChanged;
            Theme = GaugeTheme.NotDefined;
            base.InfoMode = GaugeInfoMode.NONE;
            ThemeData = null;
        }

        private void PanelGaugeComponentBase_ParentChanged(object sender, EventArgs e)
        {
            //Set drawing style based on it's parent.

            if (Parent is GaugePanel)
            {
                //Reset Standalone Style
                SetStyle(ControlStyles.OptimizedDoubleBuffer, false);
                SetStyle(ControlStyles.AllPaintingInWmPaint, false);

                if (DesignMode)
                {
                    SetStyle(ControlStyles.UserPaint, true);
                    SetStyle(ControlStyles.ResizeRedraw, false);
                }
                else
                {
                    SetStyle(ControlStyles.UserPaint, false);
                    SetStyle(ControlStyles.ResizeRedraw, true);
                }

                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                SetStyle(ControlStyles.Opaque, true);
            }
            else
            {
                //Reset Gauge Panel Draw Style
                SetStyle(ControlStyles.ResizeRedraw, false);
                SetStyle(ControlStyles.SupportsTransparentBackColor, true);
                SetStyle(ControlStyles.Opaque, false);
                base.SetDrawingStyleStandaloneComponent();
            }
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle = cp.ExStyle | 0x20;
                return cp;
            }
        }

        protected override void Dispose(bool disposing)
        {
            base.Dispose(disposing);
        }

        [Category("Gauge Appearance")]
        [Description("Theme")]
        [DefaultValue(typeof(GaugeTheme), "NotDefined")]
        public new GaugeTheme Theme
        {
            get => base.Theme;
            set => base.Theme = value;
        }

        #region [ Hidden Properties ]

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new GaugeInfoMode InfoMode { get => base.InfoMode; set => base.InfoMode = value; }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new GaugeInfoType InfoPage { get => base.InfoPage; set => base.InfoPage = value; }

        #endregion

        #region [ Paint Background ]

        protected override void OnPaintBackground(PaintEventArgs e)
        {
            //OnPaintBackground will not be called if ControlStyle.Opaque set to true.
            if (IsDrawByPanel)
            {
                base.Visible = false;
                return;
            }
            base.Visible = Visible;
            base.OnPaintBackground(e);
        }

        /// <summary>
        /// Background painting handle by <see cref="GaugePanel"/>
        /// </summary>
        /// <param name="e"></param>
        internal void PaintBackground(PaintEventArgs e)
        {
            if (IsDrawByPanel && !Visible) return;
            Point StartPos = new Point(0, 0);
            if (IsDrawByPanel)
            {
                StartPos.X = Location.X;
                StartPos.Y = Location.Y;
            }

            //Draw background if BackColor different from parent back color.
            if (BackColor == Color.Transparent) return;
            if ((Parent is GaugePanel) && (BackColor == Parent.BackColor)) return;

            //Draw background if control's parent is not Gauge Panel / Back Color is defined by user.
            e.Graphics.FillRectangle(new SolidBrush(BackColor),
                    StartPos.X, StartPos.Y, Width, Height);
        }

        #endregion

        #region [ Paint ]

        internal override void OnPaintGauge(GaugePaintEventArgs e)
        {
            if (IsDrawByPanel) return;
            PaintBackground(e);

            if ((ThemeData == null) && (Parent is GaugePanel p))
            {
                e.Colors = p.ThemeData.Colors(DrawValueState());
            }
            PaintComponent(e);
        }

        /// <summary>
        /// Paint component
        /// </summary>
        /// <param name="e"></param>
        internal void PaintComponent(GaugePaintEventArgs e)
        {
            if (!Visible) return;

            Point StartPos = new Point(0, 0);
            if (IsDrawByPanel)
            {
                StartPos.X = Location.X;
                StartPos.Y = Location.Y;
            }
            OnPaintComponent(e, StartPos);
        }

        /// <summary>
        /// Derived class paint implementation
        /// </summary>
        /// <param name="e"></param>
        /// <param name="startPos"></param>
        internal abstract void OnPaintComponent(GaugePaintEventArgs e, Point startPos);

        #endregion

        [Category("Gauge Data")]
        [Description("Object which define limits and value.")]
        [Browsable(true)]
        [TypeConverter(typeof(GaugeDataListConverter))]
        public override GaugeData GaugeData
        {
            get => base.GaugeData;
            set => base.GaugeData = value;
        }
    }
}
