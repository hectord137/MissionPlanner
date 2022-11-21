namespace CodeArtEng.Gauge
{
    /// <summary>
    /// Pre-defined Gauge Theme
    /// </summary>
    public enum GaugeTheme
    {
        /// <summary>
        /// Theme not defined.
        /// </summary>
        NotDefined = -99,
#if !Freeware
        /// <summary>
        /// User defined theme
        /// </summary>
        UserDefined = -1,
#endif
        /// <summary>
        /// Light theme (Default)
        /// </summary>
        Light = 0,
        /// <summary>
        /// Light theme with dark panel
        /// </summary>
        Light_Dark_Background = 1,
        /// <summary>
        /// Dark theme
        /// </summary>
        Dark = 100,
        /// <summary>
        /// Dark Theme - Blue
        /// </summary>
        DarkBlue = 101,
        /// <summary>
        /// Dark Theme - Gray
        /// </summary>
        DarkGrey = 102,
        /// <summary>
        /// Dark Theme - Vintage
        /// </summary>
        DarkVintage = 103

    }
}
