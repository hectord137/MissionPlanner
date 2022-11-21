using System.Drawing;
using System.Windows.Forms;
using CodeArtEng.Gauge.Themes;

namespace CodeArtEng.Gauge.Themes
{
    /// <summary>
    /// Default theme color value for user defined color scheme.
    /// </summary>
    internal class DefaultTheme : GaugeThemeBase
    {
        public DefaultTheme(Control parent = null) :
#if Freeware
            base(GaugeTheme.NotDefined)
#else
            base(GaugeTheme.UserDefined)
#endif
        {
            Base = new ThemeColors(parent);
            Warning = new ThemeColors(parent);
            Warning.PointerColor = Color.Orange;
            Error = new ThemeColors(parent);
            Error.PointerColor = Color.Red;
        }

        public DefaultTheme(GaugeThemeBase theme, Control parent = null) : this()
        {
            if (theme == null) return;
            Base = theme.Base?.Clone() as ThemeColors;
            Warning = theme.Warning?.Clone() as ThemeColors;
            Error = theme.Error?.Clone() as ThemeColors;
        }

        public DefaultTheme() :
#if Freeware
            base(GaugeTheme.NotDefined)
#else
            base(GaugeTheme.UserDefined)
#endif
        {
            Base = new ThemeColors();
            Warning = new ThemeColors();
            Warning.PointerColor = Color.Orange;
            Error = new ThemeColors();
            Error.PointerColor = Color.Red;
        }

    }
}
