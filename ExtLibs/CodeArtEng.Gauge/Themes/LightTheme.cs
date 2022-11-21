using System.Drawing;

namespace CodeArtEng.Gauge.Themes
{
    internal class LightTheme : GaugeThemeBase
    {
        public LightTheme(): base(GaugeTheme.Light)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(0, 64, 0),
                PointerBackColor = Color.Silver,
                PointerColor = Color.Green,
                PanelBackColor = Color.FromArgb(128, 255, 128),
                PanelBorderColor = Color.Green
            };

            Warning = new ThemeColors()
            {
                TextForeColor = Color.Black,
                PointerBackColor = Color.Silver,
                PointerColor = Color.Orange,
                PanelBackColor = Color.FromArgb(255, 255, 128),
                PanelBorderColor = Color.Olive
            };

            Error = new ThemeColors()
            {
                TextForeColor = Color.Maroon,
                PointerBackColor = Color.Silver,
                PointerColor = Color.Red,
                PanelBackColor = Color.FromArgb(255, 160, 160),
                PanelBorderColor = Color.DarkRed
            };
        }

    }
}
