using System.Drawing;

namespace CodeArtEng.Gauge.ImageProcessing
{
    internal class GrayScaleImage
    {
        public int Height { get; private set; }
        public int Width { get; private set; }
        public int[,] Pixels { get; private set; } //height, width

        public GrayScaleImage(int width, int height)
        {
            Height = height;
            Width = width;
            Pixels = new int[height, width];
        }

        public ColorImage ToColorimage()
        {
            ColorImage result = new ColorImage(Width, Height);
            for (int h = 0; h < Height; h++)
            {
                for (int w = 0; w < Width; w++)
                {
                    ColorPixel p = result.Pixels[h, w];
                    p.R = p.G = p.B = Pixels[h, w];
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
                    int p = Pixels[h, w];
                    bmp.SetPixel(w, h, Color.FromArgb(p, p, p));
                }
            }
            return bmp;
        }

    }
}
