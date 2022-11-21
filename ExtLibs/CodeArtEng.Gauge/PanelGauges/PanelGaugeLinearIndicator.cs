using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge.PanelGauges
{
    /// <summary>
    /// Direction of linear pointer starting from
    /// </summary>
    public enum LinearIndicatorOrientation
    {
        /// <summary>
        /// Horizontal gauge, start from left
        /// </summary>
        LeftToRight = 0,
        /// <summary>
        /// Horizontal gauge, start from right
        /// </summary>
        RightToLeft = 1,
        /// <summary>
        /// Vertical gauge, start from bottom
        /// </summary>
        BottomToTop = 10,
        /// <summary>
        /// Vertical gauge, start from top
        /// </summary>
        TopToBottom = 11
    }


    /// <summary>
    /// Linear Gauge for <see cref="GaugePanel"/>
    /// </summary>
    public class PanelGaugeLinearIndicator : PanelGaugeComponentBase
    {
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
        [Description("Drawing Style")]
        [DefaultValue(typeof(GaugeIndicatorStyle), "Linear")]
        public GaugeIndicatorStyle DrawStyle
        {
            get => _DrawStyle;
            set { SetValue(ref _DrawStyle, value); }
        }
        private GaugeIndicatorStyle _DrawStyle = GaugeIndicatorStyle.Linear;

        [Category("Gauge Layout")]
        [Description("Indicator Orientation. Define starting point of linear pointer. Default is left to right.")]
        [DefaultValue(typeof(LinearIndicatorOrientation), "LeftToRight")]
        public LinearIndicatorOrientation Orientation
        {
            get => _Orientation;
            set { SetValue(ref _Orientation, value); }
        }
        private LinearIndicatorOrientation _Orientation = LinearIndicatorOrientation.LeftToRight;

        public PanelGaugeLinearIndicator() : base()
        {
            Size = new Size(100, 15);
        }

        private bool OrientationIsVertical() { return ((int)_Orientation >= 10); }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            try
            {

                bool drawPeak = false;
                if (PeakVisible && (Peak >= Minimum) && (Peak <= Maximum)) drawPeak = true;

                switch (DrawStyle)
                {
                    default:
                    case GaugeIndicatorStyle.Linear:
                        int valueSize = OrientationIsVertical() ? Height : Width;
                        valueSize = (int)(valueSize / (Maximum - Minimum) * (PointerValue - Minimum));

                        Rectangle valueRect;
                        switch (Orientation)
                        {
                            default:
                            case LinearIndicatorOrientation.LeftToRight:
                                valueRect = new Rectangle(StartPos.X, StartPos.Y, valueSize, Height);
                                break;
                            case LinearIndicatorOrientation.RightToLeft:
                                valueRect = new Rectangle(StartPos.X + Width - valueSize, StartPos.Y, valueSize, Height);
                                break;
                            case LinearIndicatorOrientation.BottomToTop:
                                valueRect = new Rectangle(StartPos.X, StartPos.Y + Height - valueSize, Width, valueSize);
                                break;
                            case LinearIndicatorOrientation.TopToBottom:
                                valueRect = new Rectangle(StartPos.X, StartPos.Y, Width, valueSize);
                                break;
                        }

                        e.Graphics.FillRectangle(new SolidBrush(e.PointerBackColor), new Rectangle(StartPos.X, StartPos.Y, Width, Height));
                        e.Graphics.FillRectangle(new SolidBrush(e.PointerColor), valueRect);
                        break;


                    case GaugeIndicatorStyle.Segment:
                        //Calculate segments 
                        int segOrigin = OrientationIsVertical() ? StartPos.Y : StartPos.X;
                        int pointerSize = (OrientationIsVertical() ? Height : Width) - SegmentGap;
                        int segCount = pointerSize / (SegmentSize + SegmentGap);
                        int segHeight = OrientationIsVertical() ? Width: Height;

                        double segInterval = (Maximum - Minimum) / segCount;
                        double segValueStart = Minimum;
                        double segValueEnd = -1;

                        switch (Orientation)
                        {
                            case LinearIndicatorOrientation.RightToLeft:
                            case LinearIndicatorOrientation.BottomToTop:
                                segInterval = -segInterval;
                                segValueStart = Maximum;
                                break;
                        }

                        //Draw Segments
                        for (int n = 0; n < segCount; n++)
                        {
                            if (n != 0)
                            {
                                segValueStart += segInterval;
                            }
                            segValueEnd = segValueStart + segInterval;
                            segValueEnd = Math.Min(segValueEnd, Maximum);
                            int segStart = SegmentGap + (n * (SegmentGap + SegmentSize) + segOrigin);

                            Color drawColor = e.PointerBackColor;
                            if (drawPeak && (Peak >= Math.Min(segValueStart, segValueEnd)) 
                                && (Peak < Math.Max(segValueStart,segValueEnd))) drawColor = Color.Red; //Peak
                            else if (PointerValue > segValueStart) drawColor = e.PointerColor; //Segment ON
                            else drawColor = e.PointerBackColor; //Segment OFF

                            Rectangle segment = OrientationIsVertical() ?
                                new Rectangle(StartPos.X, segStart, segHeight, SegmentSize) 
                                : new Rectangle(segStart, StartPos.Y, SegmentSize, segHeight);
                            e.Graphics.FillRectangle(new SolidBrush(drawColor), segment);
                        }
                        break;
                }

            }
            catch
            {
                e.Graphics.Clear(Color.Red);
            }
        }
    }
}
