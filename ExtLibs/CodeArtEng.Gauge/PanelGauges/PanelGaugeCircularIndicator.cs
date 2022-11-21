using System;
using System.ComponentModel;
using System.Drawing;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Circular Gauge for <see cref="GaugePanel"/>
    /// </summary>
    public class PanelGaugeCircularIndicator : PanelGaugeComponentBase
    {
        #region [ Gauge Layout ]

        /// <summary>
        /// Gauge start position where minimum value is located.
        /// Angle start at 12 o'clock position as 0 degree, clockwise.
        /// </summary>
        [Category("Gauge Layout")]
        [Description("Start angle of gauge. 0 degree start from 12 o'clock position, clockwise.")]
        [DefaultValue(0)]
        public int StartAngle
        {
            get => _StartAngle;
#if Freeware
            private
#endif
            set => SetValue(ref _StartAngle, value);
        }
        private int _StartAngle = 0;

        /// <summary>
        /// Gauge end position where maximum value is located.
        /// Angle start at 12 o'clock poistion as 0 degree, clockwise.
        /// </summary>
        [Category("Gauge Layout")]
        [Description("End angle of gauge. 0 degree start from 12 o'clock position, clockwise.")]
        [DefaultValue(360)]
        public int EndAngle
        {
            get => _EndAngle;
#if Freeware
            private
#endif
            set => SetValue(ref _EndAngle, value);
        }
        private int _EndAngle = 360;

        /// <summary>
        /// Gauge face and pointer spacing in pixels
        /// </summary>
        [Category("Gauge Layout")]
        [Description("Gauge face and pointer spacing in pixels.")]
        [DefaultValue(2)]
        public int FacePadding
        {
            get => _FacePadding;
            set => SetValue(ref _FacePadding, value);
        }
        private int _FacePadding = 2;

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

        public PanelGaugeCircularIndicator() : base()
        {
            Size = new Size(65, 65);
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            try
            {
                //Calculate Size
                int size = Math.Min(Height, Width) - 4;
                if (size % 2 == 1) size -= 1; //Size must be even number
                int radius = size / 2;
                Point center = new Point((Width / 2) + StartPos.X, (Height / 2) + StartPos.Y);
                Rectangle gaugeRect = DrawingEx.RectangleFromCenter(center, size); //new Rectangle(center.X - radius, center.Y - radius, size, size);

                switch (DrawStyle)
                {
                    default:
                    case GaugeIndicatorStyle.Linear:
                        DrawLinearGauge(e, radius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.LinearMultiColor:
                        if (IgnoreLimits) DrawLinearGauge(e, radius, gaugeRect);
                        else DrawLinearMultiColorGauge(e, radius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.Segment:
                        DrawSegmentedGauge(e, radius, gaugeRect);
                        break;

                    case GaugeIndicatorStyle.SegmentMultiColor:
                        if (IgnoreLimits) DrawSegmentedGauge(e, radius, gaugeRect);
                        else DrawSegmentedMultiColorGauge(e, radius, gaugeRect);
                        break;
                }
            }
            catch (Exception)
            {
                e.Graphics.Clear(Color.Red);
            }
        }

        private int ValueToAngle(double value) { return (int)((EndAngle - StartAngle) / (Maximum - Minimum) * (value - Minimum)) + StartAngle; }

        private void DrawLinearGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            //GAUGE POINTER
            DrawingEx.DrawArc(e.Graphics, gaugeRect, StartAngle + AngleOffset, EndAngle + AngleOffset,
               radius, radius - PointerWidth, e.PointerBackColor);
            int valueAngle = ValueToAngle(PointerValue);

            //Draw gauge pointer value
            switch (PointerPaintMode)
            {
                case PointerPaintMode.SimpleSolid:
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, StartAngle + AngleOffset, valueAngle + AngleOffset,
                        radius, radius - PointerWidth, e.PointerColor);
                    break;

                case PointerPaintMode.SimpleGradient:
                    HSVColor startColor = HSVColor.FromRGB(e.PointerColor);

                    if (IsDarkTheme)
                        startColor.Value = Math.Max(0, startColor.Value - 50);
                    else //Asssume light theme
                        startColor.Value = Math.Min(100, startColor.Value + 50);

                    DrawingEx.DrawGradientArc(e.Graphics, gaugeRect, StartAngle + AngleOffset, valueAngle + AngleOffset, EndAngle + AngleOffset,
                        radius, radius - PointerWidth, startColor.ToRGB(), e.PointerColor);
                    break;
            }

            //PEAK DETECTOR
            if (PeakVisible)
            {
                if ((Peak >= Minimum) && (Peak <= Maximum))
                {
                    int angle = (int)((EndAngle - StartAngle) / (Maximum - Minimum) * (Peak - Minimum)) + StartAngle;
                    DrawingEx.DrawArc(e.Graphics, gaugeRect, angle + AngleOffset, angle + 2 + AngleOffset,
                        radius, radius - PointerWidth, Color.Red);
                }
            }
        }

        private void DrawLinearMultiColorGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            //Calculate angle for pointer value, min and max
            int valueAngle = ValueToAngle(PointerValue);
            int valueMinAngle = StartAngle;
            int valueMaxAngle = EndAngle;

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
            //GAUGE POINTER
            double incAngle = (double)360 / SegmentCount;
            if (StartAngle > EndAngle) incAngle *= -1; //Counter Clockwise
            double incValuePerSegment = (Maximum - Minimum) / (double)(EndAngle - StartAngle) * incAngle;

            double segAngleStart = StartAngle;
            double segAngleEnd = -1;
            double segValueStart = Minimum;
            double segValueEnd = -1;

            bool drawPeak = false;
            if (PeakVisible && (Peak >= Minimum) && (Peak <= Maximum)) drawPeak = true;

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
                    if (segAngleStart > EndAngle) break;

                    segAngleEnd = Math.Min(EndAngle, segAngleStart + incAngle - SegmentGap);
                    segAngleEnd = Math.Max(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }
                else
                {
                    //Counter clockwise pointer
                    if (segAngleStart < EndAngle) break;

                    segAngleEnd = Math.Max(EndAngle, segAngleStart + incAngle + SegmentGap);
                    segAngleEnd = Math.Min(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }

                segValueEnd = segValueStart + incValuePerSegment;
                segValueEnd = Math.Min(segValueEnd, Maximum);

                Color drawColor = e.PointerBackColor;
                if (drawPeak && (Peak >= segValueStart) && (Peak < segValueEnd)) drawColor = Color.Red; //Peak
                else if (PointerValue > segValueStart) drawColor = e.PointerColor; //Segment ON

                DrawingEx.DrawArc(e.Graphics, gaugeRect, segAngleStart + AngleOffset, segAngleEnd + AngleOffset, radius, radius - PointerWidth, drawColor);
            }
        }
        
        private void DrawSegmentedMultiColorGauge(GaugePaintEventArgs e, int radius, Rectangle gaugeRect)
        {
            //GAUGE POINTER
            double incAngle = (double)360 / SegmentCount;
            if (StartAngle > EndAngle) incAngle *= -1; //Counter Clockwise
            double incValuePerSegment = (Maximum - Minimum) / (double)(EndAngle - StartAngle) * incAngle;

            double segAngleStart = StartAngle;
            double segAngleEnd = -1;
            double segValueStart = Minimum;
            double segValueEnd = -1;

            bool drawPeak = false;
            if (PeakVisible && (Peak >= Minimum) && (Peak <= Maximum)) drawPeak = true;

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
                    if (segAngleStart > EndAngle) break;

                    segAngleEnd = Math.Min(EndAngle, segAngleStart + incAngle - SegmentGap);
                    segAngleEnd = Math.Max(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }
                else
                {
                    //Counter clockwise pointer
                    if (segAngleStart < EndAngle) break;

                    segAngleEnd = Math.Max(EndAngle, segAngleStart + incAngle + SegmentGap);
                    segAngleEnd = Math.Min(segAngleStart, segAngleEnd); //End angle must not less thn start angle.
                }

                segValueEnd = segValueStart + incValuePerSegment;
                segValueEnd = Math.Min(segValueEnd, Maximum);
                Themes.ThemeColors segmentColor = e.Theme.Colors(ValueState(segValueEnd));

                Color drawColor = segmentColor.PointerBackColor; //Segment OFF
                if (drawPeak && (Peak >= segValueStart) && (Peak < segValueEnd)) drawColor = Color.Red; //Peak
                else if (PointerValue > segValueStart) drawColor = segmentColor.PointerColor; //Segment ON

                DrawingEx.DrawArc(e.Graphics, gaugeRect, segAngleStart + AngleOffset, segAngleEnd + AngleOffset, radius, radius - PointerWidth, drawColor);

            }
        }

    }
}
