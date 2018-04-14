namespace Bridge.Google.Maps
{
    /// <summary>
    ///     This object defines the properties that can be set on a KmlLayer
    ///     object.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class KmlLayerOptions
    {
        /// <summary>
        ///     If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        ///     The map on which to display the layer.
        /// </summary>
        public Map Map;

        /// <summary>
        ///     By default, the input map is centered and zoomed to the bounding
        ///     box of the contents of the layer. If this option is set to true,
        ///     the viewport is left unchanged, unless the map's center and zoom
        ///     were never set.
        /// </summary>
        public bool PreserveViewport;

        /// <summary>
        ///     Whether to render the screen overlays. Default true.
        /// </summary>
        public bool ScreenOverlays;

        /// <summary>
        ///     Suppress the rendering of info windows when layer features are
        ///     clicked.
        /// </summary>
        public bool SuppressInfoWindows;

        /// <summary>
        ///     The URL of the KML document to display.
        /// </summary>
        public string Url;

        /// <summary>
        ///     The z-index of the layer.
        /// </summary>
        public int ZIndex;
    }
}