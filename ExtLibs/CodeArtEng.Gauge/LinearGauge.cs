using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CodeArtEng.Gauge
{
    public enum LinearGugeDrawMode
    {
        Straight,
        Angled
    }

    public class LinearGauge : GaugeBase
    {
        private const int BottomGap = 2; //Internal margin from bottom and right
        private const int TextLeftOffset = 5;

        [Category("Gauge Layout")]
        [Description("Label area width.")]
        [DefaultValue(80)]
        public int LabelWidth
        {
            get => _LabelWidth;
            set => SetValue(ref _LabelWidth, value);
        }
        private int _LabelWidth = 80;

        [Category("Gauge Layout")]
        [Description("Size of each pointer segment")]
        [DefaultValue(3)]
        public int SegmentSize
        {
            get => _SegmentSize;
            set => SetValue(ref _SegmentSize, value);
        }
        private int _SegmentSize = 3;

        [Category("Gauge Layout")]
        [Description("Gap between each segment")]
        [DefaultValue(80)]
        public int SegmentGap
        {
            get => _SegmentGap;
            set => SetValue(ref _SegmentGap, value);
        }
        private int _SegmentGap = 1;

        [Category("Gauge Layout")]
        [Description("Size of end guard section")]
        [DefaultValue(10)]
        public int EndGuardWidth
        {
            get => _EndGuardMinWidth;
            set => SetValue(ref _EndGuardMinWidth, value);
        }
        private int _EndGuardMinWidth = 10;

        [Category("Gauge Layout")]
        [Description("Height of bar below segments")]
        [DefaultValue(10)]
        public int BottomBarHeight
        {
            get => _BottomBarHeight;
            set => SetValue(ref _BottomBarHeight, value);
        }
        private int _BottomBarHeight = 5;

        [Category("Gauge Layout")]
        [Description("Segment draw style")]
        [DefaultValue(typeof(LinearGugeDrawMode), "Angled")]
        public LinearGugeDrawMode DrawMode { get; set; } = LinearGugeDrawMode.Angled;

        public LinearGauge() : base()
        {
            Size = new Size(200, 30);
            //InfoMode = GaugeInfoMode.NONE;
        }

        internal override void OnPaintGauge(GaugePaintEventArgs e)
        {
            try
            {
                //Calculate segments 
                int segWidth = Width - LabelWidth - EndGuardWidth - SegmentGap;
                int segCount = segWidth / (SegmentSize + SegmentGap);
                int labelOffset = segWidth - (segCount * (SegmentSize + SegmentGap)) - SegmentGap;
                int ActualLabelWidth = LabelWidth + labelOffset;
                int segmentHeight = Height - BottomBarHeight - BottomGap;

                double segInterval = (Maximum - Minimum) / segCount;
                double segValueStart = Minimum;
                double segValueEnd = -1;

                //Draw Outline Section
                List<PointF> points = new List<PointF>();
                points.Add(new PointF(0, 0)); //P0
                points.Add(new PointF(0, Height - 1)); //P1
                points.Add(new PointF(Width - 1, Height - 1)); //P2
                points.Add(new PointF(Width - 1, 0)); //P3
                points.Add(new PointF(DrawMode == LinearGugeDrawMode.Angled ?
                    Width - segmentHeight - EndGuardWidth - BottomGap : Width - EndGuardWidth, 0)); //P4
                points.Add(new PointF(Width - EndGuardWidth, Height - BottomBarHeight)); //P5
                points.Add(new PointF(ActualLabelWidth, Height - BottomBarHeight)); //P6
                points.Add(new PointF(DrawMode == LinearGugeDrawMode.Angled ?
                    ActualLabelWidth - segmentHeight - BottomGap : ActualLabelWidth, 0)); //P7

                DrawingEx.DrawFilledPolygon(e.Graphics, e.PanelBackColor, points.ToArray());

                bool drawPeak = false;
                if (PeakVisible && (Peak >= Minimum) && (Peak <= Maximum)) drawPeak = true;

                //Draw Segments
                List<PointF> segPoints = new List<PointF>();
                for (int x = 0; x < segCount; x++)
                {
                    if (x != 0)
                    {
                        segValueStart += segInterval;
                    }
                    segValueEnd = segValueStart + segInterval;
                    segValueEnd = Math.Min(segValueEnd, Maximum);

                    segPoints.Clear();
                    int segX = ActualLabelWidth + SegmentGap + (x * (SegmentGap + SegmentSize));
                    segPoints.Add(new PointF(DrawMode == LinearGugeDrawMode.Angled ?
                        segX - segmentHeight : segX, 0)); //S0
                    segPoints.Add(new PointF(segX, segmentHeight)); //S1
                    segPoints.Add(new PointF(segX + SegmentSize, segmentHeight));
                    segPoints.Add(new PointF(DrawMode == LinearGugeDrawMode.Angled ?
                        segX + SegmentSize - segmentHeight : segX + SegmentSize, 0));

                    Color drawColor = e.PointerBackColor;
                    if (drawPeak && (Peak >= segValueStart) && (Peak < segValueEnd)) drawColor = Color.Red; //Peak
                    else if (PointerValue > segValueStart) drawColor = e.PointerColor; //Segment ON
                    else drawColor = e.PointerBackColor; //Segment OFF

                    DrawingEx.DrawFilledPolygon(e.Graphics, drawColor, segPoints.ToArray());

                }

                GraphicsPath path = new GraphicsPath();
                path.AddPolygon(points.ToArray());
                e.Graphics.DrawPath(new Pen(e.PanelBorderColor), path);

                //Draw Text
                SizeF strTitleSize = string.IsNullOrEmpty(Title) ? new SizeF(0, 0) : e.Graphics.MeasureString(Title, FontTitle);
                SizeF strValueSize = e.Graphics.MeasureString(DrawValueStr, Font);
                SizeF strUnitSize = string.IsNullOrEmpty(Unit) ? new SizeF(0, 0) : e.Graphics.MeasureString(Unit, Font);

                Rectangle titleRect = new Rectangle(TextLeftOffset, 0, (int)strTitleSize.Width, (int)strTitleSize.Height);
                Rectangle valueRect = new Rectangle(TextLeftOffset, 0, (int)strValueSize.Width, (int)strValueSize.Height);
                Rectangle unitRect = new Rectangle(TextLeftOffset, 0, (int)strUnitSize.Width, (int)strUnitSize.Height);

                //Line 1
                valueRect.Y = Height / 2 - valueRect.Height / 2;
                valueRect.Y = valueRect.Y + (titleRect.Height / 2);

                //Line 0
                titleRect.Y = valueRect.Y - titleRect.Height;

                //Line 2
                unitRect.X = valueRect.X + valueRect.Width;
                unitRect.Y = valueRect.Y;

                TextFormatFlags textFlags = TextFormatFlags.Bottom | TextFormatFlags.Left;

                TextRenderer.DrawText(e.Graphics, Title, FontTitle, titleRect, e.TextColor);
                TextRenderer.DrawText(e.Graphics, DrawValueStr, Font, valueRect, e.TextColor, textFlags);
                TextRenderer.DrawText(e.Graphics, Unit, FontUnitLabel, unitRect, e.TextColor, textFlags);

            }
            catch (Exception)
            {
                e.Graphics.Clear(Color.Red);
            }
        }

        internal override void DrawGaugeInfo(GaugePaintEventArgs e, GaugeInfoType infoType)
        {
            Rectangle r = new Rectangle(0, 0, Width - BottomGap, Height - BottomGap);

            e.Graphics.DrawRectangle(new Pen(e.PanelBorderColor), r);
            e.Graphics.FillRectangle(new SolidBrush(e.PanelBackColor), r);

            //Draw Value and Unit same as Gauge
            SizeF strValueSize = e.Graphics.MeasureString(DrawValueStr, Font);
            SizeF strUnitSize = string.IsNullOrEmpty(Unit) ? new SizeF(0, 0) : e.Graphics.MeasureString(Unit, Font);

            Rectangle valueRect = new Rectangle(TextLeftOffset, 0, (int)strValueSize.Width, (int)strValueSize.Height);
            Rectangle unitRect = new Rectangle(TextLeftOffset, 0, (int)strUnitSize.Width, (int)strUnitSize.Height);

            valueRect.Y = Height / 2 - valueRect.Height / 2;
            unitRect.X = valueRect.X + valueRect.Width;
            unitRect.Y = valueRect.Y;

            TextRenderer.DrawText(e.Graphics, DrawValueStr, Font, valueRect, e.TextColor);
            TextRenderer.DrawText(e.Graphics, Unit, FontUnitLabel, unitRect, e.TextColor);

            //Draw Gauge Info
            Point refPoint = new Point(LabelWidth, Height / 2);

            List<string> lines = new List<string>();

            switch (infoType)
            {
                case GaugeInfoType.Range:
                    lines.Add(string.Format("Range: {0} - {1} {2}", Minimum, Maximum, Unit)); // Limit
                    break;

                case GaugeInfoType.Limits:
                    bool warningLimitDefined = !Double.IsNaN(WarningLimit);
                    bool errorLimitDefined = !Double.IsNaN(ErrorLimit);
                    if (warningLimitDefined && errorLimitDefined)
                    {
                        lines.Add("Warning: " + WarningLimit.ToString());
                        lines.Add("Error  : " + ErrorLimit.ToString());
                    }
                    else if (!warningLimitDefined && !errorLimitDefined) lines.Add("N/A");
                    else
                    {
                        if (warningLimitDefined) lines.Add("Warning: " + WarningLimit.ToString());
                        if (errorLimitDefined)   lines.Add("Error  : " + ErrorLimit.ToString());
                    }
                    break;
            }

            DrawMultiLines(e, refPoint, lines.ToArray(), HorizontalAlignment.Left);

        }
    }
}
