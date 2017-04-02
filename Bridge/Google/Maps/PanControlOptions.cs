namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the pan control.
    /// Note: The Pan control is not available in the new set of controls introduced in v3.22 of the Google Maps JavaScript API.While using v3.22 and v3.23, you can choose to use the earlier set of controls rather than the new controls, thus making the Pan control available as part of the old control set.See What's New in the v3.22 Map Controls.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PanControlOptions
    {
        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition Position;
    }
}