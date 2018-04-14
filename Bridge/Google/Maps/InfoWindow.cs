namespace Bridge.Google.Maps
{
    using Html5;

    /// <summary>
    ///     An overlay that looks like a bubble and is often connected to a marker.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class InfoWindow
    {
        /// <summary>
        ///     Creates an info window with the given options.
        ///     An InfoWindow can be placed on a map at a particular position or
        ///     above a marker, depending on what is specified in the options.
        ///     Unless auto-pan is disabled, an InfoWindow will pan the map to make
        ///     itself visible when it is opened.
        ///     After constructing an InfoWindow, you must call open to display it
        ///     on the map.
        ///     The user can click the close button on the InfoWindow to remove it
        ///     from the map, or the developer can call close() for the same
        ///     effect.
        /// </summary>
        /// <param name="opts">Options parameter.</param>
        public extern InfoWindow(InfoWindowOptions opts = null);

        /// <summary>
        ///     Closes this InfoWindow by removing it from the DOM structure.
        /// </summary>
        public extern void Close();

        /// <summary>
        ///     The get content.
        /// </summary>
        /// <returns>
        ///     The info window content.
        /// </returns>
        public extern Union<string, Node> GetContent();

        /// <summary>
        ///     The get position.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public extern LatLng GetPosition();

        /// <summary>
        ///     Opens this InfoWindow on the given map. Optionally, an InfoWindow
        ///     can be associated with an anchor.
        ///     In the core API, the only anchor is the Marker class.
        ///     However, an anchor can be any MVCObject that exposes a LatLng
        ///     position property and optionally a Point anchorPoint property for
        ///     calculating the pixelOffset (see InfoWindowOptions).
        ///     The anchorPoint is the offset from the anchor's position to the tip
        ///     of the InfoWindow.
        /// </summary>
        /// <param name="map">
        ///     The map.
        /// </param>
        /// <param name="anchor">
        ///     The anchor.
        /// </param>
        public extern void Open(Union<StreetViewPanorama, Map> map = null, object anchor = null);

        /// <summary>
        ///     The set content.
        /// </summary>
        /// <param name="content">
        ///     The content.
        /// </param>
        public extern void SetContent(Union<string, Node> content);

        /// <summary>
        ///     The set position.
        /// </summary>
        /// <param name="position">
        ///     The position.
        /// </param>
        public extern void SetPosition(Union<LatLng, LatLngLiteral> position);

        /// <summary>
        ///     The set z index.
        /// </summary>
        /// <param name="zIndex">
        ///     The z index.
        /// </param>
        public extern void SetZIndex(int zIndex);
    }
}