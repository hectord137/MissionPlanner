using System.Drawing;
using CodeArtEng.Gauge.Themes;
using System.Windows.Forms;

namespace CodeArtEng.Gauge
{
    internal class GaugePaintEventArgs : PaintEventArgs
    {
        public GaugePaintEventArgs(Graphics graphics, Rectangle clipRect, GaugeThemeBase theme, ThemeColors colors)
            : base(graphics, clipRect)
        {
            Theme = theme;
            Colors = colors;
        }
        public GaugePaintEventArgs(PaintEventArgs p, GaugeThemeBase theme, ThemeColors colors) :
            this(p.Graphics, p.ClipRectangle, theme, colors)
        { }

        public GaugeThemeBase Theme { get; private set; }
        public ThemeColors Colors { get; set; }

        public Color TextColor { get => Colors.TextForeColor; }
        public Color ScaleLabelColor { get => Colors.ScaleLabelColor; }
        public Color MajorTickLineColor { get => Colors.MajorTickLineColor; }
        public Color MinorTickLineColor { get => Colors.MinorTickLineColor; }   
        public Color PointerBackColor { get => Colors.PointerBackColor; }
        public Color PointerColor { get => Colors.PointerColor; }
        public Color PanelBackColor { get => Colors.PanelBackColor; }
        public Color PanelBorderColor { get => Colors.PanelBorderColor; }
        public Color NeedleColor { get => Colors.NeedleColor; }
        public Color PeakMarkerColor { get => Colors.PeakMarkerColor; }
    }
}
