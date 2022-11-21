using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace CodeArtEng.Gauge
{
    public enum RectangleIndicatorDrawStyle
    {
        Rectangle,
        RoundedRectangle,
        Hexagon1,
        Hexagon2,
        Pentagon1,
        Pentagon2,
        Pentagon3,
        Pentagon4
    }


    public class RectangleIndicator : GaugeBase
    {
        [Category("Gauge Layout")]
        [Description("Gauge border drawing style.")]
        [DefaultValue(typeof(RectangleIndicatorDrawStyle), "Rectangle")]
        public RectangleIndicatorDrawStyle DrawStyle
        {
            get => _DrawStyle;
            set => SetValue(ref _DrawStyle, value);
        }
        private RectangleIndicatorDrawStyle _DrawStyle = RectangleIndicatorDrawStyle.Rectangle;

        [Category("Gauge Layout")]
        [Description("Gauge corner radius.")]
        [DefaultValue(10)]
        public int CornerSize
        {
            get => _CornerSize;
            set => SetValue(ref _CornerSize, value);
        }
        private int _CornerSize = 10;

        public RectangleIndicator() : base()
        {
            base.Size = new Size(70, 40);
        }

        internal override void OnPaintGauge(GaugePaintEventArgs e)
        {
            try
            {
                DrawShapeOutline(e);

                SizeF strTitleSize = string.IsNullOrEmpty(Title) ? new SizeF(0, 0) : e.Graphics.MeasureString(Title, FontTitle);
                SizeF strValueSize = e.Graphics.MeasureString(DrawValueStr, Font);
                SizeF strUnitSize = string.IsNullOrEmpty(Unit) ? new SizeF(0, 0) : e.Graphics.MeasureString(Unit, FontUnitLabel);

                Point center = new Point(Width / 2, Height / 2);
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
            catch
            {
                e.Graphics.Clear(Color.Red);
            }
        }

        private void DrawShapeOutline(GaugePaintEventArgs e)
        {
            GraphicsPath path = new GraphicsPath();
            List<PointF> points = new List<PointF>();
            Rectangle boundRect = new Rectangle(Padding.Left, Padding.Top, Width - Padding.Right - 1, Height - Padding.Bottom - 1);

            switch (DrawStyle)
            {
                case RectangleIndicatorDrawStyle.Rectangle:
                    points.Add(new PointF(Padding.Left, Padding.Top)); //Top Left
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1)); //Bottom Left
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - 1)); //Bottom Right
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top)); //Top Right
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.RoundedRectangle: //Rounded Rectangle
                    int diameter = CornerSize * 2;
                    Rectangle arcRec = new Rectangle(0, 0, diameter, diameter);
                    arcRec.X = boundRect.X;
                    arcRec.Y = boundRect.Y;
                    path.AddArc(arcRec, 180, 90); //Top Left
                    arcRec.X = boundRect.X + boundRect.Width - diameter;
                    path.AddArc(arcRec, 270, 90); //Top Right
                    arcRec.Y = boundRect.Y + boundRect.Height - diameter;
                    path.AddArc(arcRec, 0, 90); //Bottom Right
                    arcRec.X = boundRect.X;
                    path.AddArc(arcRec, 90, 90); //Bottom Left
                    path.CloseFigure();
                    break;

                case RectangleIndicatorDrawStyle.Hexagon1: //Hexagon
                    points.Add(new PointF(Padding.Left, Padding.Top + CornerSize)); //Top Left - 1
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1)); //Bottom Left
                    points.Add(new PointF(Width - Padding.Right - CornerSize - 1, Height - Padding.Bottom - 1));  //Bottom Right - 1
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - CornerSize - 1));  //Bottom Right - 2
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top)); //Top Right
                    points.Add(new PointF(Padding.Left + CornerSize, Padding.Top)); //Top Left - 2
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.Hexagon2: //Hexagon
                    points.Add(new PointF(Padding.Left, Padding.Top)); //Top Left
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1 - CornerSize)); //Bottom Left - 1
                    points.Add(new PointF(Padding.Left + CornerSize, Height - Padding.Bottom - 1)); //Bottom Left - 2
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - 1)); //Bottom Right
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top + CornerSize)); //Top Right - 1
                    points.Add(new PointF(Width - Padding.Right - 1 - CornerSize, Padding.Top)); //Top Right - 2
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.Pentagon1: //Pentagon - Top Left
                    points.Add(new PointF(Padding.Left, Padding.Top + CornerSize)); //Top Left - 1
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1)); //Bottom Left
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - 1)); //Bottom Right
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top)); //Top Right
                    points.Add(new PointF(Padding.Left + CornerSize, Padding.Top)); //Top Left - 2
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.Pentagon2: //Pentagon - Bottom Left
                    points.Add(new PointF(Padding.Left, Padding.Top)); //Top Left
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1 - CornerSize)); //Bottom Left - 1
                    points.Add(new PointF(Padding.Left + CornerSize, Height - Padding.Bottom - 1)); //Bottom Left - 2
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - 1)); //Bottom Right
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top)); //Top Right
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.Pentagon3: //Pentagon - Bottom Right
                    points.Add(new PointF(Padding.Left, Padding.Top)); //Top Left
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1)); //Bottom Left
                    points.Add(new PointF(Width - Padding.Right - CornerSize - 1, Height - Padding.Bottom - 1));  //Bottom Right - 1
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - CornerSize - 1));  //Bottom Right - 2
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top)); //Top Right
                    path.AddPolygon(points.ToArray());
                    break;

                case RectangleIndicatorDrawStyle.Pentagon4: //Pentagon - Top Right
                    points.Add(new PointF(Padding.Left, Padding.Top)); //Top Left
                    points.Add(new PointF(Padding.Left, Height - Padding.Bottom - 1)); //Bottom Left
                    points.Add(new PointF(Width - Padding.Right - 1, Height - Padding.Bottom - 1)); //Bottom Right
                    points.Add(new PointF(Width - Padding.Right - 1, Padding.Top + CornerSize)); //Top Right - 1
                    points.Add(new PointF(Width - Padding.Right - 1 - CornerSize, Padding.Top)); //Top Right - 2
                    path.AddPolygon(points.ToArray());
                    break;

                default: throw new ArgumentOutOfRangeException("DrawStyle");
            }

            e.Graphics.DrawPath(new Pen(e.PanelBorderColor), path);
            e.Graphics.FillPath(new SolidBrush(e.PanelBackColor), path);
        }

        internal override void DrawGaugeInfo(GaugePaintEventArgs e, GaugeInfoType infoType)
        {
            try
            {
                DrawShapeOutline(e);

                List<string> lines = new List<string>();
                switch (infoType)
                {
                    case GaugeInfoType.Range:
                        lines.Add(string.Format("{0} - {1} {2}", Minimum, Maximum, Unit)); // Limit
                        break;

                    case GaugeInfoType.Limits:
                        bool warningLimitDefined = !Double.IsNaN(WarningLimit);
                        bool errorLimitDefined = !Double.IsNaN(ErrorLimit);
                        lines.Add("W: " + (warningLimitDefined ? WarningLimit.ToString() : " -- "));
                        lines.Add("E: " + (errorLimitDefined ? ErrorLimit.ToString() : " -- "));
                        break;
                }

                Point center = new Point(Width / 2, Height / 2);
                DrawMultiLines(e, center, lines.ToArray());
            }
            catch
            {
                e.Graphics.Clear(Color.Red);
            }
        }

        #region [ Properties Hidden from GaugeBase ]

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new bool PeakVisible
        {
            get => false;
            set => throw new NotImplementedException();
        }

        [Browsable(false)]
        [DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
        public new int PeakHoldDuration
        {
            get => 0;
            set => throw new NotImplementedException();
        }

        #endregion
    }
}
