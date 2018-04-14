namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Styles for the zoom control.
    ///     Note: Zoom control styles are not available in the new set of controls
    ///     introduced in v3.22 of the Google Maps JavaScript API.While using v3.22
    ///     and v3.23, you can choose to use the earlier set of controls rather
    ///     than the new controls, thus making the large Zoom control available as
    ///     part of the old control set.See What's New in the v3.22 Map Controls.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ZoomControlStyle
    {
        /// <summary>
        ///     The default zoom control. When the DEFAULT control is shown it,
        ///     will vary according to map size and other factors. The DEFAULT
        ///     control may change in future versions of the API.
        /// </summary>
        [Name("DEFAULT")]
        Default,

        /// <summary>
        ///     The larger control, with the zoom slider in addition to +/-
        ///     buttons.
        /// </summary>
        [Name("LARGE")]
        Large,

        /// <summary>
        ///     A small control with buttons to zoom in and out.
        /// </summary>
        [Name("SMALL")]
        Small
    }
}