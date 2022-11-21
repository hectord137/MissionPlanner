using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge.ImageProcessing
{
    internal static class Adjustment
    {
        public static ColorImage Threshold(this ColorImage image, int threshold)
        {
            ColorImage result = new ColorImage(image.Width, image.Height);
            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    ColorPixel p = image.Pixels[h, w];
                    int avg = (p.R + p.G + p.B) / 3;


                    if (avg >= threshold) 
                        p.R = p.G = p.B = 255;
                    else p.R = p.G = p.B = 0;
                }
            }
            return result;
        }

        public static GrayScaleImage Threshold(this GrayScaleImage image, int threshold)
        {
            GrayScaleImage result = new GrayScaleImage(image.Width, image.Height);
            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    result.Pixels[h, w] = image.Pixels[h, w] >= threshold ? 255 : 0;
                }
            }
            return result;
        }

        public static GrayScaleImage Invert(this GrayScaleImage image)
        {
            GrayScaleImage result = new GrayScaleImage(image.Width, image.Height);
            for (int w = 0; w < image.Width; w++)
            {
                for (int h = 0; h < image.Height; h++)
                {
                    result.Pixels[h, w] = 255 - image.Pixels[h, w];
                }
            }
            return result;
        }
    }
}
