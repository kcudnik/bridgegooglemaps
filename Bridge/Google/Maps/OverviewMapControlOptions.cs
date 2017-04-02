namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the Overview Map control.
    /// Note: The Overview Map control is not available in the new set of
    /// controls introduced in v3.22 of the Google Maps JavaScript API.While
    /// using v3.22 and v3.23, you can choose to use the earlier set of
    /// controls rather than the new controls, thus making the Overview Map
    /// control available as part of the old control set.See What's New in the
    /// v3.22 Map Controls.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class OverviewMapControlOptions
    {
        /// <summary>
        /// Whether the control should display in opened mode or collapsed
        /// (minimized) mode. By default, the control is closed.
        /// </summary>
        public bool Opened;
    }
}
