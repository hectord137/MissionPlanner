using System.Drawing;

namespace CodeArtEng.Gauge.Themes
{
    internal class LightThemeDarkBackground : GaugeThemeBase
    {
        public LightThemeDarkBackground(): base(GaugeTheme.Light_Dark_Background)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(128, 255, 128),
                ScaleLabelColor = Color.White,
                PointerBackColor = Color.Silver,
                PointerColor = Color.Green,
                PanelBackColor = Color.FromArgb(0, 120, 0),
                PanelBorderColor = Color.Green
            };

            Warning = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 255, 128),
                ScaleLabelColor = Color.White,
                PointerBackColor = Color.Silver,
                PointerColor = Color.Orange,
                PanelBackColor = Color.FromArgb(229, 95, 0),
                PanelBorderColor = Color.Olive
            };

            Error = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(255, 192, 192),
                ScaleLabelColor = Color.White,
                PointerBackColor = Color.Silver,
                PointerColor = Color.Red,
                PanelBackColor = Color.FromArgb(120, 0, 0),
                PanelBorderColor = Color.DarkRed
            };
        }

    }
}
