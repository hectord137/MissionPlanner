namespace System.Drawing
{
    internal struct HSVColor
    {
        /// <summary>
        /// Hue [0 to 360]
        /// </summary>
        public int Hue { get; set; }

        /// <summary>
        /// Saturation [0 to 100]
        /// </summary>
        public int Saturation { get; set; }

        /// <summary>
        /// Value [0 to 100]
        /// </summary>
        public int Value { get; set; }

        /// <summary>
        /// Opacity - Alpha [0 to 255]
        /// </summary>
        public int Alpha { get; set; }

        public HSVColor(int hue, int saturation, int value) : this(255, hue, saturation, value) { }

        public HSVColor(int alpha, int hue, int saturation, int value)
        {
            Hue = hue;
            Saturation = saturation;
            Value = value;
            Alpha = alpha;
        }

        /// <summary>
        /// Convert this HSV color to RGB <see cref="Color"/>
        /// </summary>
        public Color ToRGB()
        {
            float hue = this.Hue;
            float sat = (float)this.Saturation / 100;
            float val = (float)this.Value / 100;
            float r = 0;
            float g = 0;
            float b = 0;

            int hueIndex = (int)Math.Floor(hue / 60) % 6;
            float f = hue / 60 - (float)Math.Floor(hue / 60);

            val *= 255;
            int v = (int)val;
            int p = (int)(val * (1.0 - sat));
            int q = (int)(val * (1.0 - f * sat));
            int t = (int)(val * (1.0 - (1.0 - f) * sat));

            switch (hueIndex)
            {
                case 0: r = v; g = t; b = p; break;
                case 1: r = q; g = v; b = p; break;
                case 2: r = p; g = v; b = t; break;
                case 3: r = p; g = q; b = v; break;
                case 4: r = t; g = p; b = v; break;
                case 5: r = v; g = p; b = q; break;
            }

            return Color.FromArgb(Alpha, (int)r, (int)g, (int)b);
        }

        /// <summary>
        /// Create HSV Color from RGB <see cref="Color"/>
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static HSVColor FromRGB(Color color)
        {
            return FromRGB(color.A, color.R, color.G, color.B);
        }

        /// <summary>
        /// Create HSV Color from RGB <see cref="Color"/>
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static HSVColor FromRGB(int r, int g, int b) { return FromRGB(255, r, g, b); }

        /// <summary>
        /// Create HSV Color from RGB <see cref="Color"/> and alpha channel.
        /// </summary>
        /// <param name="color"></param>
        /// <returns></returns>
        public static HSVColor FromRGB(int a, int r, int g, int b)
        {
            HSVColor hsv = new HSVColor();

            float max = Math.Max(r, Math.Max(g, b));
            float min = Math.Min(r, Math.Min(g, b));

            hsv.Value = (int)((max * 100) / 255);

            float delta = max - min;

            if (max > 0)
            {
                hsv.Saturation = (int)(delta / max * 100);
            }
            else
            {
                // r = g = b = 0
                hsv.Saturation = 0;
                hsv.Hue = 0; // Undefined
                return hsv;
            }

            if (delta == 0)
            {
                hsv.Hue = 0;
            }
            else
            {
                if (r == max)
                    hsv.Hue = (int)(60 * (g - b) / delta);    // Between yellow and magenta
                else if (g == max)
                    hsv.Hue = (int)(60 * (2 + (b - r) / delta)); // Between cyan and yellow
                else
                    hsv.Hue = (int)(60 * (4 + (r - g) / delta)); // Between magenta and cyan

                if (hsv.Hue < 0) hsv.Hue += 360;
            }

            hsv.Alpha = a;
            return hsv;
        }

        //public static implicit operator RGBColor(HSVColor hsv)
        //{
        //    return hsv.ToRGB();
        //}

        //public static implicit operator HSVColor(RGBColor rgb)
        //{
        //    return HSVColor.FromRGB(rgb);
        //}
    }
}
