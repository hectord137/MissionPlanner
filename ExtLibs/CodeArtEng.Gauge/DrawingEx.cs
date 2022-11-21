//#define DEBUG_PEN

using System;
using System.Collections.Generic;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Windows.Forms;
using VerticalAlignment = System.Windows.Forms.VisualStyles.VerticalAlignment;

namespace CodeArtEng.Gauge
{
    internal static class DrawingEx
    {
        //PI radians = 180 degrees
        private static double AngleToRadian(double angle) { return (angle * Math.PI) / 180; }
        private static double RadianToAngle(double radians) { return (radians * 180) / Math.PI; }

        /// <summary>
        /// Return point from center of circle. Zero degree at 3 o'clock position
        /// </summary>
        /// <param name="center">Coordinate of circle center point</param>
        /// <param name="radius">Radius of circle in pixels</param>
        /// <param name="angle">Angle in degree</param>
        /// <returns></returns>
        public static PointF DistanceFromCircleCenter(PointF center, float radius, double angle)
        {
            //Trigonometri function of Circle
            // x = cos(angle), y = sin(angle)
            double radians = AngleToRadian(angle);
            return new PointF((float)(center.X + radius * (Math.Cos(radians))),
                              (float)(center.Y + radius * (Math.Sin(radians))));
        }

        /// <summary>
        /// Return square region from center and length of square
        /// </summary>
        /// <param name="center">center position</param>
        /// <param name="length">length / width of square region</param>
        /// <returns></returns>
        public static Rectangle RectangleFromCenter(Point center, int length)
        {
            return RectangleFromCenter(center, length, length);
        }

        /// <summary>
        /// Return rectangle from center, width and height.
        /// </summary>
        /// <param name="center"></param>
        /// <param name="width"></param>
        /// <param name="height"></param>
        /// <returns></returns>
        public static Rectangle RectangleFromCenter(Point center, int width, int height)
        {
            Rectangle result = new Rectangle(0, 0, width, height);
            result.X = center.X - width / 2;
            result.Y = center.Y - height / 2;
            return result;
        }

        /// <summary>
        /// Return rectangle from reference point, size and alignment
        /// </summary>
        /// <param name="referencePoint"></param>
        /// <param name="alignment"></param>
        /// <param name="height"></param>
        /// <param name="verticalAlignment"></param>
        /// <param name="width"></param>
        /// <returns></returns>
        public static Rectangle RectangleFromReference(Point referencePoint, int width, int height, HorizontalAlignment alignment,
            VerticalAlignment verticalAlignment = VerticalAlignment.Center)
        {
            Rectangle result = new Rectangle(referencePoint.X, referencePoint.Y, width, height);
            

            switch (alignment)
            {
                case HorizontalAlignment.Right:
                    result.X -= result.Width;
                    break;

                case HorizontalAlignment.Center:
                    result.X -= result.Width / 2;
                    break;
            }

            switch(verticalAlignment)
            {
                case VerticalAlignment.Center:
                    result.Y -= result.Height / 2;
                    break;

                case VerticalAlignment.Bottom:
                    result.Y -= result.Height;
                    break;

            }

            return result;
        }

        /// <summary>
        /// Get center point from rectangle region
        /// </summary>
        /// <param name="region"></param>
        /// <returns></returns>
        public static PointF CenterFromRectangle(Rectangle region)
        {
            return new PointF((region.Width / 2) + region.X, (region.Height / 2) + region.Y);
        }

        private static GraphicsPath GetArcPath(Point center, double startAngle, double endAngle, int outerRadius, int innerRadius)
        {
            GraphicsPath path = new GraphicsPath();
            PointF point1 = DistanceFromCircleCenter(center, innerRadius, startAngle);
            PointF point2 = DistanceFromCircleCenter(center, outerRadius, startAngle);
            PointF point3 = DistanceFromCircleCenter(center, outerRadius, endAngle);
            PointF point4 = DistanceFromCircleCenter(center, innerRadius, endAngle);

            path.AddLine(point1, point2);
            path.AddArc(center.X - outerRadius, center.Y - outerRadius, outerRadius * 2, outerRadius * 2, (float)startAngle, (float)(endAngle - startAngle));
            path.AddLine(point3, point4);
            path.AddArc(center.X - innerRadius, center.Y - innerRadius, innerRadius * 2, innerRadius * 2, (float)startAngle, (float)(endAngle - startAngle));

            return path;
        }

        /// <summary>
        /// Draw filled arc in defined color.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="size"></param>
        /// <param name="startAngle"></param>
        /// <param name="endAngle"></param>
        /// <param name="outerRadius"></param>
        /// <param name="innerRadius"></param>
        /// <param name="color"></param>
        public static void DrawArc(this Graphics g, Rectangle size, double startAngle, double endAngle, int outerRadius, int innerRadius, Color color)
        {
            Point center = new Point(size.Width / 2 + size.X, size.Height / 2 + size.Y);
            using (GraphicsPath arcPath = GetArcPath(center, startAngle, endAngle, outerRadius, innerRadius))
            {
                #region [ DEBUG ]
#if DEBUG_PEN
            Pen pen = new Pen(new SolidBrush(Color.Black));
            g.DrawPath(pen, arcPath);
            g.DrawRectangle(pen, size);
#endif
                #endregion

                g.FillPath(new SolidBrush(color), arcPath);
            }
        }

        /// <summary>
        /// Draw donut arc in defined color gradient. Required min 2 colors.
        /// </summary>
        /// <param name="g"></param>
        /// <param name="size"></param>
        /// <param name="startAngle"></param>
        /// <param name="endAngle"></param>
        /// <param name="outerRadius"></param>
        /// <param name="innerRadius"></param>
        /// <param name="colors"></param>
        public static void DrawGradientArc(this Graphics g, Rectangle size, double startAngle, double endAngle, double gradientEndAngle, int outerRadius, int innerRadius, params Color[] colors)
        {
            List<PointF> debugPoints = new List<PointF>();
            Point center = new Point(size.Width / 2 + size.X, size.Height / 2 + size.Y);

            using (GraphicsPath arcPath = GetArcPath(center, startAngle, endAngle, outerRadius, innerRadius))
            {
                using (Brush brush = GetGradientBrush(size, center, startAngle, gradientEndAngle, colors, debugPoints))
                {
                    g.SetClip(arcPath);

                    #region [ DEBUG ]
#if DEBUG_PEN
            Pen pen = new Pen(new SolidBrush(Color.Black));
            g.DrawPath(pen, arcPath);
            g.DrawPolygon(pen, debugPoints.ToArray());
#endif
                    #endregion

                    g.FillPath(brush, arcPath);
                    g.ResetClip();
                }
            }
        }

        private static Color[] GenerateColorPalette(Color[] colors)
        {
            List<Color> results = new List<Color>();
            if (colors == null) throw new ArgumentNullException("colors");
            if (colors.Length < 2) throw new ArgumentException("Minimum 2 colors required.");
            if (colors.Length >= 6)
            {
                results.AddRange(colors);
                results.Add(colors.First());
                return results.ToArray();
            }

            //Length for colors is [2 to 5]
            const int Segments = 12;
            int segmentSize = Segments / (colors.Length - 1);

            int colorIndex; //Base color index
            int subIndex;   //Interpolation index
            for (int x = 0; x < Segments; x++)
            {
                colorIndex = (int)Math.Floor((double)(x / segmentSize));
                subIndex = x % segmentSize;

                if (subIndex == 0) results.Add(colors[colorIndex]);
                else
                {
                    //Get Interpolation with HSV
                    HSVColor c1 = HSVColor.FromRGB(colors[colorIndex]);
                    HSVColor c2 = HSVColor.FromRGB(colors[colorIndex + 1]);
                    results.Add(new HSVColor(
                                    c1.Hue + (c2.Hue - c1.Hue) * subIndex / segmentSize,
                                    c1.Saturation + (c2.Saturation - c1.Saturation) * subIndex / segmentSize,
                                    c1.Value + (c2.Value - c1.Value) * subIndex / segmentSize
                                    ).ToRGB());
                }
            }
            results.Add(colors.Last());

            return results.ToArray();
        }

        private static PathGradientBrush GetGradientBrush(RectangleF size, PointF centerOfBrush, double startAngle, double endAngle, Color[] colors, List<PointF> pathPoints = null)
        {
            //Put a polygon to the GraphicsPath, so that there are PathPoints at the places where the colors should be
            //Calculate number of points based on number of colors.

            Color[] AdjustedColors = GenerateColorPalette(colors);
            int n = AdjustedColors.Length;
            PointF[] points = new PointF[AdjustedColors.Length];

            //Get Rectangle Center point
            PointF center = new PointF(size.Width / 2 + size.X, size.Height / 2 + size.Y);

            //Calculate angle increment
            double deltaAngle = endAngle - startAngle;
            double incAngle = deltaAngle / (n - 1);
            for (int x = 0; x < n; x++)
            {
                points[x] = DistanceFromCircleCenter(center, (float)(size.Height * 0.55), incAngle * x + startAngle);
            }

            //points[points.Length - 1] = points.First(); //Last = first, close loop
            PathGradientBrush fBrush = new PathGradientBrush(points);

            fBrush.CenterPoint = centerOfBrush;
            //fBrush.CenterColor = Color.White;
            fBrush.CenterColor = Color.FromArgb((int)AdjustedColors.Average(x => x.A),
                                                (int)AdjustedColors.Average(x => x.R),
                                                (int)AdjustedColors.Average(x => x.G),
                                                (int)AdjustedColors.Average(x => x.B)
                                                );
            fBrush.SurroundColors = AdjustedColors;
            pathPoints?.AddRange(points);
            return fBrush;
        }

        /// <summary>
        /// Draw single color filled polygon
        /// </summary>
        /// <param name="g"></param>
        /// <param name="fillColor"></param>
        /// <param name="points"></param>
        public static void DrawFilledPolygon(this Graphics g, Color fillColor, params PointF[] points)
        {
            if (points == null) return;
            if (points.Count() < 3) return;

            using (GraphicsPath path = new GraphicsPath())
            {

                PointF currentPoint, nextPoint;
                currentPoint = nextPoint = points.First();
                for (int x = 1; x < points.Count(); x++)
                {
                    nextPoint = points[x];
                    path.AddLine(currentPoint, nextPoint);
                    currentPoint = nextPoint;
                }

                path.AddLine(nextPoint, points.First()); //Close
                g.FillPath(new SolidBrush(fillColor), path);
            }
        }

        public static void DrawGradientElipse(this Graphics g, Rectangle region, Color centerColor, Color surroundColor)
        {
            DrawGradientElipse(g, region, centerColor, surroundColor, CenterFromRectangle(region));
        }

        public static void DrawGradientElipse(this Graphics g, Rectangle region, Color centerColor, Color surroundColor, PointF center)
        {
            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(region);
                using (PathGradientBrush gradBrush = new PathGradientBrush(path))
                {
                    gradBrush.CenterPoint = center;
                    gradBrush.CenterColor = centerColor;
                    gradBrush.SurroundColors = new Color[] { surroundColor };

                    g.FillPath(gradBrush, path);
                }
            }
        }

        /// <summary>
        /// Align content within target region.
        /// </summary>
        /// <param name="target"></param>
        /// <param name="content"></param>
        public static void AlignRectangle(Rectangle target, ref Rectangle content, ContentAlignment align)
        {
            switch (align)
            {
                case ContentAlignment.TopLeft:
                    XAlign(target, ref content, HorizontalAlignment.Left);
                    YAlign(target, ref content, VeritcalAlignment.Top);
                    break;

                case ContentAlignment.TopCenter:
                    XAlign(target, ref content, HorizontalAlignment.Center);
                    YAlign(target, ref content, VeritcalAlignment.Top);
                    break;

                case ContentAlignment.TopRight:
                    XAlign(target, ref content, HorizontalAlignment.Right);
                    YAlign(target, ref content, VeritcalAlignment.Top);
                    break;

                case ContentAlignment.MiddleLeft:
                    XAlign(target, ref content, HorizontalAlignment.Left);
                    YAlign(target, ref content, VeritcalAlignment.Center);
                    break;

                case ContentAlignment.MiddleCenter:
                    XAlign(target, ref content, HorizontalAlignment.Center);
                    YAlign(target, ref content, VeritcalAlignment.Center);
                    break;

                case ContentAlignment.MiddleRight:
                    XAlign(target, ref content, HorizontalAlignment.Right);
                    YAlign(target, ref content, VeritcalAlignment.Center);
                    break;

                case ContentAlignment.BottomLeft:
                    XAlign(target, ref content, HorizontalAlignment.Left);
                    YAlign(target, ref content, VeritcalAlignment.Bottom);
                    break;

                case ContentAlignment.BottomCenter:
                    XAlign(target, ref content, HorizontalAlignment.Center);
                    YAlign(target, ref content, VeritcalAlignment.Bottom);
                    break;

                case ContentAlignment.BottomRight:
                    XAlign(target, ref content, HorizontalAlignment.Right);
                    YAlign(target, ref content, VeritcalAlignment.Bottom);
                    break;
            }
        }

        private static void XAlign(Rectangle target, ref Rectangle content, HorizontalAlignment hAlign)
        {
            switch (hAlign)
            {
                case HorizontalAlignment.Left:
                    content.X = target.X;
                    break;
                case HorizontalAlignment.Right:
                    content.X = target.X + (target.Width - content.Width);
                    break;
                case HorizontalAlignment.Center:
                    content.X = target.X + ((target.Width - content.Width) / 2);
                    break;
            }
        }

        private enum VeritcalAlignment
        {
            Top, Center, Bottom
        }

        private static void YAlign(Rectangle target, ref Rectangle content, VeritcalAlignment vAlign)
        {
            switch (vAlign)
            {
                case VeritcalAlignment.Top:
                    content.Y = target.Y;
                    break;
                case VeritcalAlignment.Center:
                    content.Y = target.Y + ((target.Height - content.Height) / 2);
                    break;
                case VeritcalAlignment.Bottom:
                    content.Y = target.Y + (target.Height - content.Height);
                    break;
            }
        }
    }
}
