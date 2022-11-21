using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing.Drawing2D;
using System.ComponentModel;

namespace CodeArtEng.Gauge.PanelGauges
{
    public enum PanelGaugeShapeDrawStyle
    {
        Rectangle,
        RoundedRectangle,
        Hexagon1,
        Hexagon2,
        Pentagon1,
        Pentagon2,
        Pentagon3,
        Pentagon4,
        Circle
    }

    /// <summary>
    /// Data aware shape for <see cref="GaugePanel"/>
    /// </summary>
    public class PanelGaugeShape : PanelGaugeComponentBase
    {
        [Category("Gauge Layout")]
        [Description("Gauge border drawing style.")]
        [DefaultValue(typeof(RectangleIndicatorDrawStyle), "Rectangle")]
        public PanelGaugeShapeDrawStyle DrawStyle
        {
            get => _DrawStyle;
            set => SetValue(ref _DrawStyle, value);
        }
        private PanelGaugeShapeDrawStyle _DrawStyle = PanelGaugeShapeDrawStyle.Rectangle;

        [Category("Gauge Layout")]
        [Description("Gauge corner radius. Not applicable for Rectangle and Circle")]
        [DefaultValue(10)]
        public int CornerSize
        {
            get => _CornerSize;
            set => SetValue(ref _CornerSize, value);
        }
        private int _CornerSize = 10;

        [Category("Gauge Layout")]
        [Description("Define if inner area of the shape should be filled.")]
        [DefaultValue(true)]
        public bool FillShape
        {
            get => _Fill;
            set => SetValue(ref _Fill, value);
        }
        private bool _Fill = true;

        public PanelGaugeShape() : base()
        {
            base.Size = new Size(70, 40);
        }

        internal override void OnPaintComponent(GaugePaintEventArgs e, Point StartPos)
        {
            try
            {
                GraphicsPath path = new GraphicsPath();
                List<PointF> points = new List<PointF>();
                Rectangle boundRect = new Rectangle(StartPos.X, StartPos.Y, Width - 1, Height - 1);

                Brush brush = new SolidBrush(e.PanelBackColor);
                Pen pen = new Pen(e.PanelBorderColor);
                switch (DrawStyle)
                {
                    case PanelGaugeShapeDrawStyle.Rectangle:
                        if(FillShape) e.Graphics.FillRectangle(brush, boundRect);
                        e.Graphics.DrawRectangle(pen, boundRect);
                        return;

                    case PanelGaugeShapeDrawStyle.RoundedRectangle: //Rounded Rectangle
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

                    case PanelGaugeShapeDrawStyle.Hexagon1: //Hexagon
                        points.Add(new PointF(boundRect.Left, boundRect.Top + CornerSize)); //Top Left 
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height)); //Bottom Left
                        points.Add(new PointF(boundRect.Left + boundRect.Width - CornerSize, boundRect.Top + boundRect.Height));  //Bottom Right 
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height - CornerSize));  //Bottom Right - 2
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top)); //Top Right
                        points.Add(new PointF(boundRect.Left + CornerSize, boundRect.Top)); //Top Left - 2
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Hexagon2: //Hexagon
                        points.Add(new PointF(boundRect.Left, boundRect.Top)); //Top Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height - CornerSize)); //Bottom Left 
                        points.Add(new PointF(boundRect.Left + CornerSize, boundRect.Top + boundRect.Height)); //Bottom Left - 2
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height)); //Bottom Right
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + CornerSize)); //Top Right 
                        points.Add(new PointF(boundRect.Left + boundRect.Width - CornerSize, boundRect.Top)); //Top Right - 2
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Pentagon1: //Pentagon - Top Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top + CornerSize)); //Top Left 
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height)); //Bottom Left
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height)); //Bottom Right
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top)); //Top Right
                        points.Add(new PointF(boundRect.Left + CornerSize, boundRect.Top)); //Top Left - 2
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Pentagon2: //Pentagon - Bottom Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top)); //Top Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height - CornerSize)); //Bottom Left 
                        points.Add(new PointF(boundRect.Left + CornerSize, boundRect.Top + boundRect.Height)); //Bottom Left - 2
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height)); //Bottom Right
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top)); //Top Right
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Pentagon3: //Pentagon - Bottom Right
                        points.Add(new PointF(boundRect.Left, boundRect.Top)); //Top Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height)); //Bottom Left
                        points.Add(new PointF(boundRect.Left + boundRect.Width - CornerSize, boundRect.Top + boundRect.Height));  //Bottom Right 
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height - CornerSize));  //Bottom Right - 2
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top)); //Top Right
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Pentagon4: //Pentagon - Top Right
                        points.Add(new PointF(boundRect.Left, boundRect.Top)); //Top Left
                        points.Add(new PointF(boundRect.Left, boundRect.Top + boundRect.Height)); //Bottom Left
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + boundRect.Height)); //Bottom Right
                        points.Add(new PointF(boundRect.Left + boundRect.Width, boundRect.Top + CornerSize)); //Top Right 
                        points.Add(new PointF(boundRect.Left + boundRect.Width - CornerSize, boundRect.Top)); //Top Right - 2
                        path.AddPolygon(points.ToArray());
                        break;

                    case PanelGaugeShapeDrawStyle.Circle:
                        if(FillShape) e.Graphics.FillEllipse(brush, boundRect);
                        e.Graphics.DrawEllipse(pen, boundRect);
                        return;

                    default: throw new ArgumentOutOfRangeException("DrawStyle");
                }

                e.Graphics.DrawPath(pen, path);
                if(FillShape) e.Graphics.FillPath(brush, path);
            }
            catch
            {
                e.Graphics.Clear(Color.Red);
            }
        }

    }
}
