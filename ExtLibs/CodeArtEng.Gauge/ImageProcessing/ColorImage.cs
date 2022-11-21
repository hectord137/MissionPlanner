using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge.ImageProcessing
{

    internal class ColorPixel
    {
        public int R { get; set; } = 0;
        public int G { get; set; } = 0;
        public int B { get; set; } = 0;
        public ColorPixel() { }
        public ColorPixel(int r, int g, int b) { R = r; G = g; B = b; }
        public ColorPixel(Color color) { Assign(color); }
        public void Assign(Color color) { R = color.R; G = color.G; B = color.B; }
        public int GrayValue() { return (R + G + B) / 3; }
    }

    internal class ColorImage
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public ColorPixel[,] Pixels { get; private set; }  //height, width

        public ColorImage(int width, int height)
        {
            Height = height;
            Width = width;
            Pixels = new ColorPixel[Height, Width];
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                    Pixels[h, w] = new ColorPixel();
            }
        }

        public ColorImage(Image sender)
        {
            Height = sender.Height;
            Width = sender.Width;
            Pixels = new ColorPixel[Height, Width];

            Bitmap bmp = new Bitmap(sender);
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    Pixels[h, w] = new ColorPixel(bmp.GetPixel(w, h));
                }
            }

        }

        public GrayScaleImage ToGrayScaleImage()
        {
            GrayScaleImage result = new GrayScaleImage(Width, Height);
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    ColorPixel p = Pixels[h, w];
                    result.Pixels[h, w] = (p.R + p.G + p.B) / 3;
                }
            }
            return result;
        }

        public Image ToImage()
        {
            Bitmap bmp = new Bitmap(Width, Height);
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    ColorPixel p = Pixels[h, w];
                    bmp.SetPixel(w, h, Color.FromArgb(p.R, p.G, p.B));
                }
            }
            return bmp;
        }
    }
}
