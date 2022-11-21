using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge.Themes
{
    internal class DarkBlueTheme : GaugeThemeBase
    {
        public DarkBlueTheme(): base(GaugeTheme.DarkBlue)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(220, 220, 220),
                ScaleLabelColor = Color.FromArgb(220, 220, 220),
                MajorTickLineColor = Color.FromArgb(122, 150, 173),
                MinorTickLineColor = Color.FromArgb(122, 150, 173),
                PointerBackColor = Color.FromArgb(10, 24, 38),
                PointerColor = Color.FromArgb(71, 102, 140),
                PanelBackColor = Color.FromArgb(22, 49, 76),
                PanelBorderColor = Color.FromArgb(122, 150, 173),
                NeedleColor = Color.FromArgb(0,178,255)
            };

            Warning = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 255, 128),
                ScaleLabelColor = Color.FromArgb(220, 220, 220),
                MajorTickLineColor = Color.FromArgb(122, 150, 173),
                MinorTickLineColor = Color.FromArgb(122, 150, 173),
                PointerBackColor = Color.FromArgb(10, 24, 38),
                PointerColor = Color.FromArgb(200, 160, 0),
                PanelBackColor = Color.FromArgb(60, 60, 0),
                PanelBorderColor = Color.FromArgb(192, 192, 0),
                NeedleColor = Color.FromArgb(255, 255, 128)
            };

            Error = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 192, 192),
                ScaleLabelColor = Color.FromArgb(220, 220, 220),
                MajorTickLineColor = Color.FromArgb(122, 150, 173),
                MinorTickLineColor = Color.FromArgb(122, 150, 173),
                PointerBackColor = Color.FromArgb(10, 24, 38),
                PointerColor = Color.FromArgb(180, 0, 0),
                PanelBackColor = Color.FromArgb(60, 0, 0),
                PanelBorderColor = Color.FromArgb(255, 128, 128),
                NeedleColor = Color.FromArgb(255, 127, 127)
            };
        }

    }
}
