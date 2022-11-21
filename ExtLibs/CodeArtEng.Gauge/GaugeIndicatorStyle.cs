namespace CodeArtEng.Gauge
{
    /// <summary>
    /// Gauge indicator draw style
    /// </summary>
    public enum GaugeIndicatorStyle
    {
        /// <summary>
        /// Linear gauge, whole indicator color changed according to limit.
        /// </summary>
        Linear,
        /// <summary>
        /// Segmented gauge, whole indicator color changed according to limit.
        /// </summary>
        Segment,
        /// <summary>
        /// Linear gauge, range draw according to defined limit.
        /// </summary>
        LinearMultiColor,
        /// <summary>
        /// Segmented gauge, range draw according to defined limit.
        /// </summary>
        SegmentMultiColor
    }
}
