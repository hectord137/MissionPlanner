using System.Drawing;

namespace CodeArtEng.Gauge.Themes
{
    internal class DarkTheme : GaugeThemeBase
    {
        public DarkTheme() : base(GaugeTheme.Dark)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(128, 255, 128),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.Gray,
                MinorTickLineColor = Color.Gray,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(0, 200, 0),
                PanelBackColor = Color.FromArgb(0, 60, 0),
                PanelBorderColor = Color.FromArgb(0, 192, 0)
            };

            Warning = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 255, 128),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.Gray,
                MinorTickLineColor = Color.Gray,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(229, 187, 0),
                PanelBackColor = Color.FromArgb(60, 60, 0),
                PanelBorderColor = Color.FromArgb(192, 192, 0),
            };

            Error = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 192, 192),
                ScaleLabelColor = Color.Silver,
                MajorTickLineColor = Color.Gray,
                MinorTickLineColor = Color.Gray,
                PointerBackColor = Color.FromArgb(22, 22, 22),
                PointerColor = Color.FromArgb(220, 0, 0),
                PanelBackColor = Color.FromArgb(60, 0, 0),
                PanelBorderColor = Color.FromArgb(255, 128, 128),
                NeedleColor = Color.FromArgb(255, 127, 127)
            };
        }
    }
}