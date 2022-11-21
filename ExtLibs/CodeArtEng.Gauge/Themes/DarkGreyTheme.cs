using System;
using System.Drawing;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeArtEng.Gauge.Themes
{
    class DarkGreyTheme : GaugeThemeBase
    {
        public DarkGreyTheme() : base(GaugeTheme.DarkGrey)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(220, 220, 220),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.White,
                MinorTickLineColor = Color.White,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(150, 150, 150),
                PanelBackColor = Color.FromArgb(22, 22, 22),
                PanelBorderColor = Color.FromArgb(122, 122, 122),
                NeedleColor = Color.White
            };

            Warning = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 255, 128),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.White,
                MinorTickLineColor = Color.White,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(200, 160, 0),
                PanelBackColor = Color.FromArgb(60, 60, 0),
                PanelBorderColor = Color.FromArgb(192, 192, 0),
            };

            Error = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 192, 192),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.White,
                MinorTickLineColor = Color.White,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(180, 0, 0),
                PanelBackColor = Color.FromArgb(60, 0, 0),
                PanelBorderColor = Color.FromArgb(255, 128, 128),
                NeedleColor = Color.FromArgb(255, 127, 127)
            };
        }
    }
}
