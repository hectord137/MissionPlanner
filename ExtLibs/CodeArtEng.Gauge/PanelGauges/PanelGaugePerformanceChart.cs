using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Net.Http.Headers;
using System.Diagnostics;
using System.Windows.Forms.VisualStyles;

namespace CodeArtEng.Gauge.PanelGauges
{
#if Freeware
#else
    public class PanelGaugePerformanceChart : PanelGaugeComponentBase
    {
        [Category("Gauge Layout")]
        [Description("Distance between 2 data points in pixels.")]
        [DefaultValue(5)]
        public int DataGap { get; set; } = 5;

        [Category("Gauge Layout")]
        [Description("Gauge border thickness.")]
        [DefaultValue(2)]
        public int GaugeBorderWidth { get; set; } = 2;

        [Category("Gauge Layout")]
        [Description("Label area width. Set value to 0 to hide label.")]
        [DefaultValue(25)]
        public int LabelWidth
        {
            get => _LabelWidth;
            set => SetValue(ref _LabelWidth, value);
        }
        private int _LabelWidth = 25;

        [Category("Gauge Layout")]
        [Description("Label Format. Refer to String.Format")]
        public string LabeLFormat
        {
            get => _LabelFormat;
            set => SetValue(ref _LabelFormat, value);
        }
        private string _LabelFormat;

        [Category("Gauge Appearance")]
        [Description("Fill Mode. Chart area fill mode.")]
        [DefaultValue(typeof(GaugeFillMode), "Gradient")]
        public GaugeFillMode FillMode { get; set; } = GaugeFillMode.Gradient;


        public PanelGaugePerformanceChart() : base()
        {
            Size = new Size(150, 60);
            PointerSupportAnimation = false;
            GaugeValueChangedDelegate = GaugeValueChangedCallback;
            UpdateRegions();
        }

        private Rectangle DrawRegion, ChartRegion, LabelRegion, ChartBorderRegion, InnerChartRegion;
        private Size LastDrawSize = new Size(0, 0);
        private int DataSize = 0;
        private double DeltaPerPixel = 0, OriginValue = 0;
        private Point Origin = new Point();
        private Point LastPoint = new Point();

        private class DataPoint
        {
            public double Value { get; private set; }
            public DataPoint(double value) { Value = value; }
            public int X { get; set; }
            public int Y { get; set; }
            public Point GetPoint() { return new Point(X, Y); }
        }
        private List<DataPoint> DataPoints = new List<DataPoint>();

        protected override void OnAutoSizeChanged(EventArgs e)
        {
            Refresh();
        }

        private string FormatLabel(double value)
        {
            try
            {
                if (string.IsNullOrEmpty(LabeLFormat)) return value.ToString();
                else if (LabeLFormat.StartsWith("X")) return Convert.ToInt64(value).ToString(LabeLFormat);
                else return value.ToString(LabeLFormat);
            }
            catch { return value.ToString(); }
        }

        private void GaugeValueChangedCallback()
        {
            AddDataPoint(GaugeData.Value);
            Refresh();
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            try
            {
                if (!Size.Equals(LastDrawSize))
                {
                    UpdateRegions(StartPos);
                    LastDrawSize = new Size(Size.Width, Size.Height);
                }

                e.Graphics.FillRectangle(new SolidBrush(e.PointerBackColor), ChartBorderRegion);

                #region [ DEBUG ]
                //e.Graphics.DrawRectangle(new Pen(Color.Green, 1), ChartRegion);
                //e.Graphics.DrawRectangle(new Pen(Color.Lime, GaugeBorderWidth), ChartBorderRegion);
                //e.Graphics.DrawRectangle(new Pen(Color.DarkGreen, 1), ChartBorderRegion);
                //e.Graphics.DrawRectangle(new Pen(Color.Blue, 1), LabelRegion);
                //e.Graphics.DrawRectangle(new Pen(Color.White, 1), InnerChartRegion);
                #endregion

                //Draw Min and Max Text
                string maxLabelString = FormatLabel(Maximum);
                string minLabelString = FormatLabel(Minimum);

                SizeF maxLabelSize = e.Graphics.MeasureString(maxLabelString, Font);
                SizeF minLabelSize = e.Graphics.MeasureString(minLabelString, Font);

                if (LabelWidth >= Math.Max(maxLabelSize.Width, minLabelSize.Width))
                {
                    //Max Label
                    Rectangle maxLabelRect = DrawingEx.RectangleFromReference(new Point(ChartRegion.X - 2, ChartRegion.Y),
                                                (int)maxLabelSize.Width, (int)maxLabelSize.Height, HorizontalAlignment.Right,
                                                System.Windows.Forms.VisualStyles.VerticalAlignment.Top);
                    TextRenderer.DrawText(e.Graphics, maxLabelString, Font, maxLabelRect, e.TextColor);

                    //Min Label
                    Rectangle minLabelRect = DrawingEx.RectangleFromReference(new Point(ChartRegion.X - 2, ChartRegion.Y + ChartRegion.Height),
                                                (int)minLabelSize.Width, (int)minLabelSize.Height, HorizontalAlignment.Right,
                                                System.Windows.Forms.VisualStyles.VerticalAlignment.Bottom);
                    TextRenderer.DrawText(e.Graphics, minLabelString, Font, minLabelRect, e.TextColor);
                }


                //Fill Chart Region with Gradient Color
                if (DataPoints.Count > 0)
                {
                    GraphicsPath polygonShape = new GraphicsPath();
                    List<Point> polygonPoints = DataPoints.Select(x => x.GetPoint()).ToList();
                    polygonPoints.Insert(0, Origin);
                    polygonPoints.Add(LastPoint);
                    polygonShape.AddPolygon(polygonPoints.ToArray());
                    polygonShape.CloseFigure();

                    //Gradient Fill
                    Brush polygonBrush = new SolidBrush(e.PointerColor);
                    if (FillMode == GaugeFillMode.Gradient)
                    {
                        int minYPos = DataPoints.Min(x => x.Y); //Upper
                        int maxYPos = DataPoints.Max(x => x.Y); //Lower

                        Point gradientStart = new Point(Origin.X, minYPos);
                        Point gradientStop = new Point(Origin.X, Origin.Y);
                        if (Origin.Y != maxYPos)
                        {
                            double distFromMinYPos = Origin.Y - minYPos;
                            double distFromMaxYPos = maxYPos - Origin.Y;

                            if (distFromMaxYPos > distFromMinYPos)
                            {
                                gradientStart = new Point(Origin.X, maxYPos);
                                gradientStop = new Point(Origin.X, Origin.Y);
                            }
                        }
                        else gradientStop.Y += 2; //Workaround to prevent gradient fill repeat himself at border line.
                        if(gradientStart != gradientStop)
                        polygonBrush = new LinearGradientBrush(gradientStart, gradientStop, e.PointerColor, e.PointerBackColor) { WrapMode = WrapMode.TileFlipX };
                    }
                    e.Graphics.FillPath(polygonBrush, polygonShape);

                    //Draw Chart Line
                    Pen tPen = new Pen(e.PointerColor, 1);
                    for (int x = 1; x < polygonPoints.Count - 2; x++)
                    {
                        e.Graphics.DrawLine(tPen, polygonPoints[x], polygonPoints[x + 1]);
                    }
                }


                //Draw zero line.
                VerticalAlignment valueLabelVerticalAlignemnt = VerticalAlignment.Center;
                if ((Minimum < 0) && (Maximum > 0))
                {
                    e.Graphics.DrawLine(new Pen(e.PanelBorderColor, 0.5F) { DashPattern = new float[] { 2, 3 } }, Origin, new Point(DataPointXPos(DataSize), Origin.Y));
                    valueLabelVerticalAlignemnt = VerticalAlignment.Bottom;
                }

                //Draw value label
                if (DataPoints.Count > 0)
                {
                    string valueString = DrawValueStr;
                    SizeF valueSize = e.Graphics.MeasureString(valueString, Font);
                    Rectangle valueRect = DrawingEx.RectangleFromReference(new Point(ChartRegion.X - 2 + ChartRegion.Width, ChartRegion.Y + (ChartRegion.Height / 2)),
                                            (int)valueSize.Width, (int)valueSize.Height, HorizontalAlignment.Right, valueLabelVerticalAlignemnt);
                    TextRenderer.DrawText(e.Graphics, valueString, Font, valueRect, e.TextColor);
                }

                //Draw border last
                e.Graphics.DrawRectangle(new Pen(e.PanelBorderColor, GaugeBorderWidth), ChartBorderRegion);

            }
            catch
            {
                e.Graphics.Clear(Color.Red);
                Demo = false;
            }
        }

        private void UpdateRegions() { UpdateRegions(new Point(0, 0)); }
        private void UpdateRegions(Point StartPos)
        {
            //Identify Active Region, region for Chart and Label
            DrawRegion = new Rectangle(StartPos.X + Padding.Left, StartPos.Y + Padding.Top,
                                            Width - Padding.Horizontal - 1, Height - Padding.Vertical - 1);
            int chartWidth = Math.Max(0, DrawRegion.Width - LabelWidth);
            ChartRegion = new Rectangle(DrawRegion.X + LabelWidth, DrawRegion.Y, chartWidth, DrawRegion.Height);
            LabelRegion = new Rectangle(DrawRegion.X, DrawRegion.Y, LabelWidth, DrawRegion.Height);

            //Identify Region for Border
            int borderOffset = GaugeBorderWidth / 2;
            ChartBorderRegion = new Rectangle(ChartRegion.X + borderOffset, ChartRegion.Y + borderOffset,
                                                    ChartRegion.Width - (GaugeBorderWidth - 1),
                                                    ChartRegion.Height - (GaugeBorderWidth - 1));

            //Identify Inner Chart Plotting Region
            InnerChartRegion = new Rectangle(ChartRegion.X + GaugeBorderWidth, ChartRegion.Y + GaugeBorderWidth,
                                                    ChartRegion.Width - 2 * (GaugeBorderWidth), ChartRegion.Height - 2 * (GaugeBorderWidth));
            if ((GaugeBorderWidth % 2) == 0)
            {
                ChartBorderRegion.Y -= 1;
                ChartBorderRegion.Height += 1;
            }

            OriginValue = ((Minimum < 0) && (Maximum > 0)) ? 0 : Minimum;
            DeltaPerPixel = (Maximum - Minimum) / InnerChartRegion.Height;
            DataSize = (InnerChartRegion.Width / DataGap) + 1;
            Origin = new Point(DataPointXPos(0), DataValueToPixel(OriginValue)); 

            if ((DataPoints.Count > DataSize) && !DesignMode)
            {
                //Resize Data, keep the last N datas
                DataPoints.RemoveRange(0, DataPoints.Count - DataSize);
            }

            //Recalculate all data points
            for (int x = 0; x < DataPoints.Count; x++)
            {
                DataPoint point = DataPoints[x];
                point.X = DataPointXPos(x);
                point.Y = DataValueToPixel(point.Value);
            }

            LastPoint = new Point(DataPointXPos(DataPoints.Count - 1), DataValueToPixel(OriginValue)); 
        }

        private void AddDataPoint(double value)
        {
            //Remove first data
            while (DataPoints.Count >= DataSize)
            {
                DataPoints.RemoveAt(0);
                for (int n = 0; n < DataPoints.Count; n++)
                    DataPoints[n].X -= DataGap;
            }

            DataPoint p = new DataPoint(value);
            p.X = DataPointXPos(DataPoints.Count);
            p.Y = DataValueToPixel(p.Value);
            DataPoints.Add(p);
            LastPoint = new Point(DataPointXPos(DataPoints.Count - 1), DataValueToPixel(OriginValue));
        }

        private int DataPointXPos(int index)
        {
            return InnerChartRegion.Left + (index * DataGap);
        }

        private int DataValueToPixel(double value)
        {
            value = Math.Max(Math.Min(Maximum, value), Minimum); //Clip to max and min
            return InnerChartRegion.Top + InnerChartRegion.Height - (int)((value - Minimum) / DeltaPerPixel);
        }
    }
#endif
}
