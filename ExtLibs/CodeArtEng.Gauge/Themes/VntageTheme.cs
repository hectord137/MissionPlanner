using System.Drawing;

namespace CodeArtEng.Gauge.Themes
{
    internal class DarkVntageTheme : GaugeThemeBase
    {
        public DarkVntageTheme() : base(GaugeTheme.DarkVintage)
        {
            Base = new ThemeColors()
            {
                TextForeColor = Color.FromArgb(248, 203, 173),
                ScaleLabelColor = Color.FromArgb(248, 203, 173),
                MajorTickLineColor = Color.FromArgb(248, 203, 173),
                MinorTickLineColor = Color.FromArgb(248, 203, 173),
                PointerBackColor = Color.FromArgb(80, 30, 8),
                PointerColor = Color.FromArgb(208, 95, 18),
                PanelBackColor = Color.FromArgb(80, 37, 8),
                PanelBorderColor = Color.FromArgb(145, 66, 13),
                NeedleColor = Color.FromArgb(248, 203, 173)
            };

            Warning = new ThemeColors()
            {
                PointerColor = Color.FromArgb(218, 166, 28),
                ScaleLabelColor = Color.FromArgb(248, 203, 173),
                MajorTickLineColor = Color.FromArgb(248, 203, 173),
                MinorTickLineColor = Color.FromArgb(248, 203, 173),
                TextForeColor = Base.TextForeColor,
                PointerBackColor = Base.PointerBackColor,
                PanelBackColor = Base.PanelBackColor,
                PanelBorderColor = Base.PanelBorderColor,
                NeedleColor = Base.NeedleColor
            };

            Error = new ThemeColors()
            {
                PointerColor = Color.FromArgb(219, 23, 23),
                ScaleLabelColor = Color.FromArgb(248, 203, 173),
                MajorTickLineColor = Color.FromArgb(248, 203, 173),
                MinorTickLineColor = Color.FromArgb(248, 203, 173),
                TextForeColor = Base.TextForeColor,
                PointerBackColor = Base.PointerBackColor,
                PanelBackColor = Base.PanelBackColor,
                PanelBorderColor = Base.PanelBorderColor,
                NeedleColor = Base.NeedleColor
            };
        }
    }
}
