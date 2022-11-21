using CodeArtEng.Gauge.Themes;

namespace CodeArtEng.Gauge
{
    public abstract class GaugeThemeBase
    {
        /// <summary>
        /// Create a new theme instance with defined ID.
        /// </summary>
        /// <param name="id"></param>
        public GaugeThemeBase(GaugeTheme id) { ID = id; }

        public GaugeTheme ID { get; }
        /// <summary>
        /// Base color scheme, normal condition.
        /// </summary>
        public ThemeColors Base { get; set; }
        /// <summary>
        /// Warning color scheme.
        /// </summary>
        public ThemeColors Warning { get; set; }
        /// <summary>
        /// Error color scheme.
        /// </summary>
        public ThemeColors Error { get; set; }

        public ThemeColors Colors(GaugeValueState state)
        {
            switch (state)
            {
                case GaugeValueState.OK: return Base;
                case GaugeValueState.Warning: return Warning;
            }
            return Error;
        }

        /// <summary>
        /// Redonly static object, default color for Gauges
        /// </summary>
        public readonly static GaugeThemeBase Default = new DefaultTheme();

    }
}
