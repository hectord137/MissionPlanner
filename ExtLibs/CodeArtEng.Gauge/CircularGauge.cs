using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace CodeArtEng.Gauge
{

    /// <summary>
    /// Circular Indicator Class
    /// </summary>
#if !Freeware
    [Designer(typeof(CircularGaugeDesigner))]
#endif
    public class CircularGauge : GaugeBase
    {
#region [ Properties - Gauge ]

#region [ Gauge Layout ]

        /// <summary>
        /// Gauge start position where minimum value is located.
        /// Angle start at 12 o'clock position as 0 degree, clockwise.
        /// </summary>
        [Category("Gauge Layout")]
        [Description("Start angle of gauge. 0 degree start from 12 o'clock position, clockwise.")]
        [DefaultValue(0)]
        public int PointerStartAngle
        {
            get => _PointerStartAngle;
#if Freeware
            private
#endif
            set => SetValue(ref _PointerStartAngle, value);
        }
        private int _PointerStartAngle = 0;

        [Obsolete("Replaced with PointerStartAngle")] //17-Sept-2022
        [DefaultValue(0)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int StartAngle { get => PointerStartAngle; set => PointerStartAngle = value; }

        /// <summary>
        /// Gauge end position where maximum value is located.
        /// Angle start at 12 o'clock poistion as 0 degree, clockwise.
        /// </summary>
        [Category("Gauge Layout")]
        [Description("End angle of gauge. 0 degree start from 12 o'clock position, clockwise.")]
        [DefaultValue(360)]
        public int PointerEndAngle
        {
            get => _PointerEndAngle;
#if Freeware
            private
#endif
            set => SetValue(ref _PointerEndAngle, value);
        }
        private int _PointerEndAngle = 360;

        [Obsolete("Replaced with PointerEndAngle")] //17-Sept-2022
        [DefaultValue(0)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int EndAngle { get => PointerEndAngle; set => PointerEndAngle = value; }

        /// <summary>
        /// Pointer bar thickness in pixels
        /// </summary>
        [Category("Gauge Layout")]
        [Description("Pointer bar thickness in pixels.")]
        [DefaultValue(5)]
        public int PointerWidth
        {
            get => _PointerWidth;
            set => SetValue(ref _PointerWidth, value);
        }
        private int _PointerWidth = 5;

        [Category("Gauge Layout")]
        [Description("Number of segments to be draw in full 360 degree circle. Range between 1 to 180.")]
        [DefaultValue(60)]
        public int SegmentCount
        {
            get => _SegmentCount;
            set
            {
                if ((value < 1) || (value > 180)) throw new ArgumentException("Value out of range!");
                SetValue(ref _SegmentCount, value);
            }
        }
        private int _SegmentCount = 60;

        [Category("Gauge Layout")]
        [Description("Spacing between each segment in pixels.")]
        [DefaultValue(1)]
        public int SegmentGap
        {
            get => _SegmentGap;
            set
            {
                if (value < 0) throw new ArgumentException("Expected positive value!");
                SetValue(ref _SegmentGap, value);
            }
        }
        private int _SegmentGap = 1;

        [Category("Gauge Layout")]
        [Description("Drawing Style")]
        [DefaultValue(typeof(GaugeIndicatorStyle), "Linear")]
        public GaugeIndicatorStyle DrawStyle
        {
            get => _DrawStyle;
            set { SetValue(ref _DrawStyle, value); }
        }
        private GaugeIndicatorStyle _DrawStyle = GaugeIndicatorStyle.Linear;

        [Category("Gauge Layout")]
        [Description("Show/Hide Gauge Sweep Pointer")]
        [DefaultValue(true)]
        public bool PointerVisible
        {
            get => _PointerVisible;
#if Freeware
            private
#endif
            set { SetValue(ref _PointerVisible, value); }
        }
        private bool _PointerVisible = true;

        [Category("Gauge Layout")]
        [Description("Show/Hide Pointer Needle")]
        [DefaultValue(false)]
        public bool NeedleVisible
        {
            get => _NeedleVisible;
#if Freeware
            private
#endif
            set { SetValue(ref _NeedleVisible, value); }
        }
        private bool _NeedleVisible = false;


        [Category("Gauge Layout")]
        [Description("Draw Needle over Gauge Panel area.")]
        [DefaultValue(false)]
        public bool NeedleOnPanel
        {
            get => _NeedleOnPanel;
#if Freeware
            private
#endif
            set => SetValue(ref _NeedleOnPanel, value);
        }
        private bool _NeedleOnPanel = false;

        [Category("Gauge Layout")]
        [Description("Needle offset from center panel when NeedleOnPanel enabled.")]
        [DefaultValue(0)]
        public int NeedleOnPanelOffset
        {
            get => _NeedleOnPanelOffset;
#if Freeware
            private
#endif
            set => SetValue(ref _NeedleOnPanelOffset, value);
        }
        private int _NeedleOnPanelOffset = 0;

        [Category("Gauge Layout")]
        [Description("Needle Width")]
        [DefaultValue(2)]
        public int NeedleWidth
        {
            get => _NeedleWidth;
#if Freeware
            private
#endif
            set { SetValue(ref _NeedleWidth, value); }
        }
        private int _NeedleWidth = 2;

        [Category("Gauge Layout")]
        [Description("Show/Hide Gauge Panel")]
        [DefaultValue(true)]
        public bool GaugePanelVisible
        {
            get => _GaugePanelVisible;
#if Freeware
            private
#endif
            set { SetValue(ref _GaugePanelVisible, value); }
        }
        private bool _GaugePanelVisible = true;

        /// <summary>
        /// Gauge face and pointer spacing in pixels
        /// </summary>
        [Category("Gauge Layout")]
        [Description("Spacing between gauge panel and pointer spacing in pixels.")]
        [DefaultValue(2)]
        public int GaugePanelPadding
        {
            get => _GaugePanelPadding;
            set => SetValue(ref _GaugePanelPadding, value);
        }
        private int _GaugePanelPadding = 2;

        [Obsolete("Replaced with GaugePanelPadding")] //17-Sept-2022
        [DefaultValue(2)]
        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public int FacePadding { get => GaugePanelPadding; set => GaugePanelPadding = value; }

        [Category("Gauge Layout")]
        [Description("Size of triangle peak marker at inner / outer gauge pointer.")]
        [DefaultValue(8)]
        public int PeakMarkerSize
        {
            get => _PeakMarkerSize;
#if Freeware
            private
#endif
            set { SetValue(ref _PeakMarkerSize, value); }
        }
        private int _PeakMarkerSize = 8;

        [Category("Gauge Layout")]
        [Description("Peak Marker Style.")]
        [DefaultValue(CircularPeakMarkerStyle.Dash)]
        public CircularPeakMarkerStyle PeakMarkerStyle
        {
            get => _PeakMarkerStyle;
#if Freeware
            private
#endif
            set { SetValue(ref _PeakMarkerStyle, value); }
        }
        private CircularPeakMarkerStyle _PeakMarkerStyle = CircularPeakMarkerStyle.Dash;

        /// <summary>
        /// Peak Marker Style
        /// </summary>
        public enum CircularPeakMarkerStyle
        {
            Dash = 0x1,                 //Marker on gauge pointer
            InnerPointer = 0x10,        //Triangle marker on inner gauge circle
            InnerPointerDash = 0x11,    //Triangle marker on inner gauge circle + pointer marker
            OuterPointer = 0x20,        //Triangle marker on outer gauge circle
            OuterPointerDash = 0x21,    //Triangle marker on outer gauge circle + pointer marker
        }

#if !Freeware
        [Category("Gauge Layout")]
        [Description("Gauge Scale Label.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CircularGaugeScaleLabel ScaleLabel { get; private set; }

        [Category("Gauge Layout")]
        [Description("Gauge Major Ticks.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CircularGaugeScaleMarker MajorTicks { get; private set; }

        [Category("Gauge Layout")]
        [Description("Gauge Minor Ticks.")]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
        public CircularGaugeScaleMarker MinorTicks { get; private set; }
#endif

        [Category("Gauge Layout")]
        [Description("Space between gauge and control.")]
        [DefaultValue(0)]
        public new int Padding
        {
            get => _Padding;
            set => SetValue(ref _Padding, value);
        }
        private int _Padding = 0;

#endregion

        /// <summary>
        /// Pointer painting mode.
        /// </summary>
        [Category("Gauge Appearance")]
        [Description("Pointer painting mode.")]
        [DefaultValue(typeof(PointerPaintMode), "SimpleSolid")]
        public PointerPaintMode PointerPaintMode
        {
            get => _PointerPainting;
            set => SetValue(ref _PointerPainting, value);
        }
        private PointerPaintMode _PointerPainting = PointerPaintMode.SimpleSolid;

        [DefaultValue(typeof(Font), "Microsoft Sans Serif, 10pt")]
        public override Font Font { get => base.Font; set => base.Font = value; }

#endregion

        /// <summary>
        /// Constructor
        /// </summary>
        public CircularGauge() : base()
        {
            base.Size = new Size(65, 65);
            base.Font = new Font("Microsoft Sans Serif", 10, FontStyle.Regular);
#if !Freeware
            ScaleLabel = new CircularGaugeScaleLabel(this);
            MajorTicks = new CircularGaugeScaleMarker(this);
            MinorTicks = new CircularGaugeScaleMarker(this);
#endif
        }

        internal override void OnPaintGauge(GaugePaintEventArgs e)
        {
            try
            {
                //Calculate Size
                int gaugeSize = Math.Min(Height, Width) - Padding - 4; //Gauge Size
                if (gaugeSize % 2 == 1) gaugeSize -= 1;   //Size must be even number

#if !Freeware
                int scaleLabelRadius = 0;
                if (ScaleLabel.Visible)
                {
                    scaleLabelRadius = gaugeSize / 2 - ScaleLabel.Padding;
                }
#endif

                if (IsOuterPeakMarkerVisible()) gaugeSize -= 2 * PeakMarkerSize;
                int pointerOuterRadius = gaugeSize / 2;          //Pointer Outer Radius
                Point center = new Point(Width / 2, Height / 2);
                Rectangle gaugeRect = DrawingEx.RectangleFromCenter(center, gaugeSize);

                //GAUGE PANEL
                int panelSize = 0;
                if (GaugePanelVisible)
                {
                    Brush solidBrush = new SolidBrush(e.PanelBackColor);
                    panelSize = gaugeSize - (2 * (PointerWidth + GaugePanelPadding));
                    Rectangle panelRect = DrawingEx.RectangleFromCenter(center, panelSize);
                    e.Graphics.FillEllipse(solidBrush, panelRect);
                    e.Graphics.DrawEllipse(new Pen(new SolidBrush(e.PanelBorderColor), 1), panelRect);
                }

                //GAUGE POINTER
                switch (DrawStyle)
                {
                    default:
                    case GaugeIndicatorStyle.Linear:
                        DrawLinearGauge(e, pointerOuterRadius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.LinearMultiColor:
                        if (IgnoreLimits) DrawLinearGauge(e, pointerOuterRadius, gaugeRect);
                        else DrawLinearMultiColorGauge(e, pointerOuterRadius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.Segment:
                        DrawSegmentedGauge(e, pointerOuterRadius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.SegmentMultiColor:
                        if (IgnoreLimits) DrawSegmentedGauge(e, pointerOuterRadius, gaugeRect);
                        else DrawSegmentedMultiColorGauge(e, pointerOuterRadius, gaugeRect);
                        break;
                }


#if !Freeware
                //GAUGE PEAK MARKER
                if (PeakVisible) DrawPeakMarker(e, gaugeRect, pointerOuterRadius);

                //GAUGE LABEL
                if (ScaleLabel.Visible)
                {
                    double scaleMin = Minimum;
                    double scaleMax = Maximum;
                    double steps = (ScaleLabel.Interval == 0) ? (Maximum - Minimum) / 10 : ScaleLabel.Interval;

                    //Avoid overlapping label at same position
                    double minAngle = (ValueToAngle(scaleMin) + 360) % 360;
                    double maxAngle = (ValueToAngle(scaleMax) + 360) % 360;
                    if (minAngle == maxAngle) scaleMin += steps;

                    for (double v = scaleMin; v <= scaleMax; v += steps)
                    {
                        int labelAngle = ValueToAngle(v);
                        string strValue = ScaleLabel.ValueToStringFormat(v * ScaleFactor);
                        SizeF strValueSize = e.Graphics.MeasureString(strValue, ScaleLabel.Font);

                        Point labelCenter = Point.Round(DrawingEx.DistanceFromCircleCenter(center, scaleLabelRadius, labelAngle + AngleOffset));
                        Rectangle labelRect = DrawingEx.RectangleFromCenter(new Point(0, 0), (int)strValueSize.Width + 1, (int)strValueSize.Height);
                        e.Graphics.TranslateTransform(labelCenter.X, labelCenter.Y);
                        if (ScaleLabel.AutoRotate)
                        {
                            e.Graphics.RotateTransform(labelAngle);
                        }
                        e.Graphics.DrawString(strValue, ScaleLabel.Font, new SolidBrush(e.ScaleLabelColor), labelRect);
                        e.Graphics.ResetTransform();
                    }
                }

                //GAUGE MARKER
                if (MinorTicks.Visible) DrawTicks(e, MinorTicks, gaugeRect, e.MinorTickLineColor);
                if (MajorTicks.Visible) DrawTicks(e, MajorTicks, gaugeRect, e.MajorTickLineColor);

                //GAUGE NEEDLE
                if (Enabled && NeedleVisible)
                {
                    if (!GaugePanelVisible)
                    {
                        e.Graphics.FillEllipse(new SolidBrush(Color.Red), DrawingEx.RectangleFromCenter(center, NeedleWidth * 3));
                    }

                    int valueAngle = ValueToAngle(PointerValue);
                    int needleStartRadius = panelSize / 2;
                    PointF needleStartPos = DrawingEx.DistanceFromCircleCenter(center, needleStartRadius, valueAngle + AngleOffset);
                    PointF needleEndPos = DrawingEx.DistanceFromCircleCenter(center, pointerOuterRadius, valueAngle + AngleOffset);
                    e.Graphics.DrawLine(new Pen(new SolidBrush(e.NeedleColor), NeedleWidth), needleStartPos, needleEndPos);

                    if (NeedleOnPanel)
                    {
                        PointF needleCenter = DrawingEx.DistanceFromCircleCenter(center, _NeedleOnPanelOffset, valueAngle + AngleOffset);
                        Pen needlePen = new Pen(new LinearGradientBrush(Point.Round(needleStartPos), needleCenter, e.NeedleColor, Color.Transparent), NeedleWidth);
                        e.Graphics.DrawLine(needlePen, needleStartPos, needleCenter);
                    }
                }
#endif

                //GAUGE TEXT
                if (GaugePanelVisible)
                {
                    SizeF strTitleSize = string.IsNullOrEmpty(Title) ? new SizeF(0, 0) : e.Graphics.MeasureString(Title, FontTitle);
                    SizeF strValueSize = e.Graphics.MeasureString(DrawValueStr, Font);
                    SizeF strUnitSize = string.IsNullOrEmpty(Unit) ? new SizeF(0, 0) : e.Graphics.MeasureString(Unit, FontUnitLabel);

                    Rectangle titleRect = DrawingEx.RectangleFromCenter(center, (int)strTitleSize.Width, (int)strTitleSize.Height);
                    Rectangle valueRect = DrawingEx.RectangleFromCenter(center, (int)strValueSize.Width, (int)strValueSize.Height);
                    Rectangle unitRect = DrawingEx.RectangleFromCenter(center, (int)strUnitSize.Width, (int)strUnitSize.Height);

                    valueRect.Y = valueRect.Y - (unitRect.Height / 2) + (titleRect.Height / 2);
                    unitRect.Y = valueRect.Y + valueRect.Height;
                    titleRect.Y = valueRect.Y - titleRect.Height;

                    TextRenderer.DrawText(e.Graphics, Title, FontTitle, titleRect, e.TextColor);
                    TextRenderer.DrawText(e.Graphics, DrawValueStr, Font, valueRect, e.TextColor);
                    TextRenderer.DrawText(e.Graphics, Unit, FontUnitLabel, unitRect, e.TextColor);
                }

            }
            catch (Exception)
            {
                e.Graphics.Clear(Color.Red);
            }
        }

#if !Freeware
        private void DrawTicks(GaugePaintEventArgs e, CircularGaugeScaleMarker marker, Rectangle gaugeRect, Color color)
        {
            if (marker.Interval <= 0) return;
            if (PointerStartAngle == PointerEndAngle) return;
            double deltaAngle = ValueToAngleDouble(Minimum + marker.Interval) - ValueToAngle(Minimum);
            int radius = gaugeRect.Width / 2 - marker.Padding;
            Point center = new Point(Width / 2, Height / 2);

            for (double a = PointerStartAngle; DrawTickLoopConditionCheck(a, PointerEndAngle, deltaAngle); a += deltaAngle)
            {
                Point markerCenter = Point.Round(DrawingEx.DistanceFromCircleCenter(center, radius, a + AngleOffset));
                e.Graphics.TranslateTransform(markerCenter.X, markerCenter.Y);
                e.Graphics.RotateTransform((float)a);
                e.Graphics.DrawLine(new Pen(color, marker.MarkerWidth), new Point(0, 0), new Point(0, marker.MarkerLength));
                e.Graphics.ResetTransform();
            }
        }

        private bool DrawTickLoopConditionCheck(double angle, double endAngle, double deltaAngle)
        {
            if (deltaAngle > 0) return (angle <= PointerEndAngle);
            return (angle >= PointerEndAngle);
        }

        private void DrawPeakMarker(GaugePaintEventArgs e, Rectangle gaugeRect, int radius)
        {
            PointF center = DrawingEx.CenterFromRectangle(gaugeRect);
            if ((Peak >= Minimum) && (Peak <= Maximum))
            {
                //Draw Triangular Peak Marker
                Color markerColor = Color.Red;
                float halfMarkerSize = (float)(PeakMarkerSize) / 2;

                int angle = ValueToAngle(Peak);
                float markerHeight = (float)Math.Sqrt(Math.Pow(PeakMarkerSize, 2) - Math.Pow(halfMarkerSize, 2));

                int markerStyle = (int)PeakMarkerStyle & 0xF0;
                //Marker tip: Pointing position.
                PointF markerTipPos = new PointF(0, 0); // Dummy
                switch (markerStyle)
                {
                    case 0x10:
                        markerTipPos = DrawingEx.DistanceFromCircleCenter(center, radius - PointerWidth, angle + AngleOffset);
                        e.Graphics.TranslateTransform(markerTipPos.X, markerTipPos.Y);
                        e.Graphics.RotateTransform(angle); //Rotate peak marker according to angular position.
                        break;

                    case 0x20:
                        markerTipPos = DrawingEx.DistanceFromCircleCenter(center, radius, angle + AngleOffset);
                        e.Graphics.TranslateTransform(markerTipPos.X, markerTipPos.Y);
                        e.Graphics.RotateTransform(angle + 180); //Rotate peak marker according to angular position.
                        break;

                    default: return;
                }

                PointF p1 = new PointF(0, 0);
                PointF p2 = new PointF(halfMarkerSize, markerHeight);
                PointF p3 = new PointF(-halfMarkerSize, markerHeight);

                GraphicsPath peakPath = new GraphicsPath();
                peakPath.AddLine(p1, p2);
                peakPath.AddLine(p2, p3);
                peakPath.CloseFigure();
                e.Graphics.FillPath(new SolidBrush(markerColor), peakPath);
                e.Graphics.ResetTransform();
            }
        }

        private double DegreeToRadian(double degree) { return (degree * Math.PI) / 180; }
        private double ValueToAngleDouble(double value) { return ((double)(PointerEndAngle - PointerStartAngle) / (Maximum - Minimum) * (value - Minimum)) + PointerStartAngle; }
#endif
        private int ValueToAngle(double value) { return (int)((PointerEndAngle - PointerStartAngle) / (Maximum - Minimum) * (value - Minimum)) + PointerStartAngle; }

        private bool IsPeakMarkerOnPointerVisible()
        {
            if (!PeakVisible) return false;
            if (((int)PeakMarkerStyle & 0x01) == 0) return false;
            return ((Peak >= Minimum) && (Peak <= Maximum));
        }

        private bool IsOuterPeakMarkerVisible()
        {
            if (!PeakVisible) return false;
            return (((int)PeakMarkerStyle & 0x20) > 0);
        }

        private void DrawLinearGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            //GAUGE POINTER
            DrawingEx.DrawArc(e.Graphics, gaugeRect, PointerStartAngle + AngleOffset, PointerEndAngle + AngleOffset,
               radius, radius - PointerWidth, e.PointerBackColor);
            int valueAngle = ValueToAngle(PointerValue);

            if (!PointerVisible) return;

            //Draw gauge pointer value
            switch (PointerPaintMode)
            {
                case PointerPaintMode.SimpleSolid:
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, PointerStartAngle + AngleOffset, valueAngle + AngleOffset,
                        radius, radius - PointerWidth, e.PointerColor);
                    break;

                case PointerPaintMode.SimpleGradient:
                    HSVColor startColor = HSVColor.FromRGB(e.PointerColor);

                    if (IsDarkTheme)
                        startColor.Value = Math.Max(0, startColor.Value - 50);
                    else //Asssume light theme
                        startColor.Value = Math.Min(100, startColor.Value + 50);

                    DrawingEx.DrawGradientArc(e.Graphics, gaugeRect, PointerStartAngle + AngleOffset, valueAngle + AngleOffset, PointerEndAngle + AngleOffset,
                        radius, radius - PointerWidth, startColor.ToRGB(), e.PointerColor);
                    break;
            }

            //Draw Peak Marker on Pointer
            if (IsPeakMarkerOnPointerVisible())
            {
                int angle = ValueToAngle(Peak);
                DrawingEx.DrawArc(e.Graphics, gaugeRect, angle + AngleOffset, angle + 2 + AngleOffset,
                    radius, radius - PointerWidth, Color.Red);
            }
        }

        private void DrawLinearMultiColorGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            //Calculate angle for pointer value, min and max
            int valueAngle = PointerVisible ? ValueToAngle(PointerValue) : ValueToAngle(Minimum);
            int valueMinAngle = PointerStartAngle;
            int valueMaxAngle = PointerEndAngle;

            if (!Enabled)
            {
                DrawLinearPointer(e, radius, gaugeRect, PointerStartAngle, PointerEndAngle, ValueToAngle(Minimum), e.PointerColor, e.PointerBackColor);
                return;
            }

            if (!double.IsNaN(ErrorLimit))
            {
                //Error limit defined, get start stop angle for error limit
                int errorMinAngle, errorMaxAngle;
                int errorLimitAngle = ValueToAngle(ErrorLimit);
                if (InvertLimit)
                {
                    errorMinAngle = valueMinAngle;
                    valueMinAngle = errorMaxAngle = errorLimitAngle;
                }
                else
                {
                    errorMaxAngle = valueMaxAngle;
                    valueMaxAngle = errorMinAngle = errorLimitAngle;
                }
                DrawLinearPointer(e, radius, gaugeRect, errorMinAngle, errorMaxAngle, valueAngle, e.Theme.Error.PointerColor, e.Theme.Error.PointerBackColor);
            }

            if (!double.IsNaN(WarningLimit))
            {
                //Warning limit defined, get start stop angle for warning limit
                int warningMinAngle, warningMaxAngle;
                int warningLimitAngle = ValueToAngle(WarningLimit);
                if (InvertLimit)
                {
                    warningMinAngle = valueMinAngle;
                    valueMinAngle = warningMaxAngle = warningLimitAngle;
                }
                else
                {
                    warningMaxAngle = valueMaxAngle;
                    valueMaxAngle = warningMinAngle = warningLimitAngle;
                }
                DrawLinearPointer(e, radius, gaugeRect, warningMinAngle, warningMaxAngle, valueAngle, e.Theme.Warning.PointerColor, e.Theme.Warning.PointerBackColor);
            }
            DrawLinearPointer(e, radius, gaugeRect, valueMinAngle, valueMaxAngle, valueAngle, e.Theme.Base.PointerColor, e.Theme.Base.PointerBackColor);

            //Draw Peak Marker on Pointer
            if (IsPeakMarkerOnPointerVisible())
            {
                int angle = ValueToAngle(Peak);
                DrawingEx.DrawArc(e.Graphics, gaugeRect, angle + AngleOffset, angle + 2 + AngleOffset,
                    radius, radius - PointerWidth, Color.Red);
            }
        }

        private void DrawLinearPointer(GaugePaintEventArgs e, int radius, Rectangle gaugeRect,
            double startAngle, double endAngle, double valueAngle,
            Color pointerColor, Color pointerBackColor)
        {
            if (startAngle == endAngle) return;

            // CW : StartAngle < EndAngle  - StartAngle < ValueAngle < EndAngle
            // CCW: StartAngle > EndAngle  - EndAngle < ValueAngle < StartAngle
            bool DirCW = (startAngle < endAngle) ? true : false;

            //if(valueAngle >= minAngle)
            if ((DirCW && (valueAngle > startAngle)) || (!DirCW && (valueAngle < startAngle)))
            {
                if ((DirCW && (valueAngle >= endAngle)) || (!DirCW && (valueAngle <= endAngle)))
                {
                    //Draw pointer for full scale
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, startAngle + AngleOffset, endAngle + AngleOffset,
                        radius, radius - PointerWidth, pointerColor);
                }
                else
                {
                    //Draw pointer
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, startAngle + AngleOffset, valueAngle + AngleOffset,
                        radius, radius - PointerWidth, pointerColor);
                    //Draw pointer background
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, valueAngle + AngleOffset, endAngle + AngleOffset,
                        radius, radius - PointerWidth, pointerBackColor);
                }
            }
            else
            {
                //Draw pointer background for full scale
                DrawingEx.DrawArc(e.Graphics, gaugeRect, startAngle + AngleOffset, endAngle + AngleOffset,
                    radius, radius - PointerWidth, pointerBackColor);
            }
        }

        private void DrawSegmentedGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            double pointerValue = PointerVisible ? PointerValue : Minimum;

            //GAUGE POINTER
            double incAngle = (double)360 / SegmentCount;
            if (PointerStartAngle > PointerEndAngle) incAngle *= -1; //Counter Clockwise
            double incValuePerSegment = (Maximum - Minimum) / (double)(PointerEndAngle - PointerStartAngle) * incAngle;

            double segAngleStart = PointerStartAngle;
            double segAngleEnd = -1;
            double segValueStart = Minimum;
            double segValueEnd = -1;

            //POINTER SEGMENTS
            for (int s = 0; s < SegmentCount; s++)
            {
                if (s != 0)
                {
                    segAngleStart += incAngle;
                    segValueStart += incValuePerSegment;
                }

                if (incAngle > 0)
                {
                    //Clockwise Pointer
                    if (segAngleStart > PointerEndAngle) break;

                    segAngleEnd = Math.Min(PointerEndAngle, segAngleStart + incAngle - SegmentGap);
                    segAngleEnd = Math.Max(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }
                else
                {
                    //Counter clockwise pointer
                    if (segAngleStart < PointerEndAngle) break;

                    segAngleEnd = Math.Max(PointerEndAngle, segAngleStart + incAngle + SegmentGap);
                    segAngleEnd = Math.Min(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }

                segValueEnd = segValueStart + incValuePerSegment;
                segValueEnd = Math.Min(segValueEnd, Maximum);

                Color drawColor = e.PointerBackColor; //Segment OFF
                if (IsPeakMarkerOnPointerVisible() && (Peak > segValueStart) && (Peak <= segValueEnd)) drawColor = Color.Red; //Peak
                else if (pointerValue > segValueStart) drawColor = e.PointerColor; //Segment ON

                DrawingEx.DrawArc(e.Graphics, gaugeRect, segAngleStart + AngleOffset, segAngleEnd + AngleOffset, radius, radius - PointerWidth, drawColor);
            }
        }

        private void DrawSegmentedMultiColorGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            double pointerValue = PointerVisible ? PointerValue : Minimum;

            //GAUGE POINTER
            double incAngle = (double)360 / SegmentCount;
            if (PointerStartAngle > PointerEndAngle) incAngle *= -1; //Counter Clockwise
            double incValuePerSegment = (Maximum - Minimum) / (double)(PointerEndAngle - PointerStartAngle) * incAngle;

            double segAngleStart = PointerStartAngle;
            double segAngleEnd = -1;
            double segValueStart = Minimum;
            double segValueEnd = -1;

            //POINTER SEGMENTS
            for (int s = 0; s < SegmentCount; s++)
            {
                if (s != 0)
                {
                    segAngleStart += incAngle;
                    segValueStart += incValuePerSegment;
                }

                if (incAngle > 0)
                {
                    //Clockwise Pointer
                    if (segAngleStart > PointerEndAngle) break;

                    segAngleEnd = Math.Min(PointerEndAngle, segAngleStart + incAngle - SegmentGap);
                    segAngleEnd = Math.Max(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }
                else
                {
                    //Counter clockwise pointer
                    if (segAngleStart < PointerEndAngle) break;

                    segAngleEnd = Math.Max(PointerEndAngle, segAngleStart + incAngle + SegmentGap);
                    segAngleEnd = Math.Min(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }

                segValueEnd = segValueStart + incValuePerSegment;
                segValueEnd = Math.Min(segValueEnd, Maximum);
                Themes.ThemeColors segmentColor = Enabled ? e.Theme.Colors(ValueState(segValueEnd)) : e.Colors;

                Color drawColor = segmentColor.PointerBackColor; //Segment OFF
                if (IsPeakMarkerOnPointerVisible() && (Peak > segValueStart) && (Peak <= segValueEnd)) drawColor = Color.Red; //Peak
                else if (pointerValue > segValueStart) drawColor = segmentColor.PointerColor; //Segment ON

                DrawingEx.DrawArc(e.Graphics, gaugeRect, segAngleStart + AngleOffset, segAngleEnd + AngleOffset, radius, radius - PointerWidth, drawColor);
            }
        }

        internal override void DrawGaugeInfo(GaugePaintEventArgs e, GaugeInfoType infoType)
        {
            //Calculate Size
            int size = Math.Min(Height, Width) - 4;
            if (size % 2 == 1) size -= 1; //Size must be even number
            int radius = size / 2;
            Point center = new Point(Width / 2, Height / 2);
            Rectangle gaugeRect = DrawingEx.RectangleFromCenter(center, size); //new Rectangle(center.X - radius, center.Y - radius, size, size);

            e.Graphics.FillEllipse(new SolidBrush(e.PanelBackColor), gaugeRect);
            e.Graphics.DrawEllipse(new Pen(new SolidBrush(e.PanelBorderColor), 1), gaugeRect);

            //1 to 3 level text -  Range + Limit, Warning, Error
            List<string> lines = new List<string>();

            switch (infoType)
            {
                case GaugeInfoType.Range:
                    lines.Add(string.Format("{0} - {1} {2}", Minimum, Maximum, Unit)); // Limit
                    break;

                case GaugeInfoType.Limits:
                    bool warningLimitDefined = !Double.IsNaN(WarningLimit);
                    bool errorLimitDefined = !Double.IsNaN(ErrorLimit);
                    if (warningLimitDefined && errorLimitDefined)
                    {
                        lines.Add("W: " + WarningLimit.ToString());
                        lines.Add("E: " + ErrorLimit.ToString());
                    }
                    else if (!warningLimitDefined && !errorLimitDefined) lines.Add("N/A");
                    else
                    {
                        if (warningLimitDefined) lines.Add("W: " + WarningLimit.ToString());
                        if (errorLimitDefined) lines.Add("E: " + ErrorLimit.ToString());
                    }
                    break;
            }

            DrawMultiLines(e, center, lines.ToArray());
        }
    }
}