namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A KmlLayer adds geographic markup to the map from a KML, KMZ or GeoRSS
    ///     file that is hosted on a publicly accessible web server.
    ///     A KmlFeatureData object is provided for each feature when clicked.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class KmlLayer : MVCObject
    {
        /// <summary>
        ///     Creates a KmlLayer which renders the contents of the specified
        ///     KML/KMZ file
        ///     (https://developers.google.com/kml/documentation/kmlreference) or
        ///     GeoRSS file (http://www.georss.org).
        /// </summary>
        /// <param name="options">Options parameter.</param>
        public extern KmlLayer(KmlLayerOptions options = null);

        /// <summary>
        ///     Get the default viewport for the layer being displayed.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLngBounds" />.
        /// </returns>
        public extern LatLngBounds GetDefaultViewport();

        /// <summary>
        ///     Get the map on which the KML Layer is being rendered.
        /// </summary>
        /// <returns>
        ///     The <see cref="Map" />.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        ///     Get the metadata associated with this layer, as specified in the
        ///     layer markup.
        /// </summary>
        /// <returns>
        ///     The <see cref="KmlLayerMetadata" />.
        /// </returns>
        public extern KmlLayerMetadata GetMetadata();

        /// <summary>
        ///     Get the status of the layer, set once the requested document has
        ///     loaded.
        /// </summary>
        /// <returns>
        ///     The <see cref="KmlLayerStatus" />.
        /// </returns>
        public extern KmlLayerStatus GetStatus();

        /// <summary>
        ///     Gets the URL of the KML file being displayed.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public extern string GetUrl();

        /// <summary>
        ///     Gets the z-index of the KML Layer.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public extern int GetZIndex();

        /// <summary>
        ///     Renders the KML Layer on the specified map. If map is set to null,
        ///     the layer is removed.
        /// </summary>
        /// <param name="map">
        ///     The map.
        /// </param>
        public extern void SetMap(Map map);

        /// <summary>
        ///     The set options.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        public extern void SetOptions(KmlLayerOptions options);

        /// <summary>
        ///     Sets the URL of the KML file to display.
        /// </summary>
        /// <param name="url">
        ///     The url.
        /// </param>
        public extern void SetUrl(string url);

        /// <summary>
        ///     Sets the z-index of the KML Layer.
        /// </summary>
        /// <param name="zIndex">
        ///     The z index.
        /// </param>
        public extern void SetZIndex(int zIndex);
    }
}