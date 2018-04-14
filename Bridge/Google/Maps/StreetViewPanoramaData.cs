namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The representation of a panorama returned from the provider defined
    ///     using registerPanoProvider.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewPanoramaData
    {
        /// <summary>
        ///     Specifies the copyright text for this panorama.
        /// </summary>
        public string Copyright;

        /// <summary>
        ///     Specifies the year and month in which the imagery in this panorama
        ///     was acquired. The date string is in the form YYYY-MM.
        /// </summary>
        public string ImageData;

        /// <summary>
        ///     Specifies the navigational links to adjacent panoramas.
        /// </summary>
        public StreetViewLink[] Links;

        /// <summary>
        ///     Specifies the location meta-data for this panorama.
        /// </summary>
        public StreetViewLocation Location;

        /// <summary>
        ///     Specifies the custom tiles for this panorama.
        /// </summary>
        public StreetViewTileData Tiles;
    }
}