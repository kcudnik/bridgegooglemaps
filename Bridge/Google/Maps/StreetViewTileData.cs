namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The properties of the tile set used in a Street View panorama.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StreetViewTileData
    {
        /// <summary>
        /// The heading (in degrees) at the center of the panoramic tiles.
        /// </summary>
        public double CenterHeading;

        /// <summary>
        /// The size (in pixels) at which tiles will be rendered.
        /// </summary>
        public Size TileSize;

        /// <summary>
        /// The size (in pixels) of the whole panorama's "world".
        /// </summary>
        public Size WorldSize;

        /// <summary>
        /// Gets the tile image URL for the specified tile.
        /// </summary>
        /// <param name="pano">
        /// The panorama ID of the Street View tile.
        /// </param>
        /// <param name="tileZoom">
        /// The zoom level of the tile.
        /// </param>
        /// <param name="tileX">
        /// The x-coordinate of the tile.
        /// </param>
        /// <param name="tileY">
        /// The y-coordinate of the tile.
        /// </param>
        /// <returns>
        /// The URL for the tile image.
        /// </returns>
        public extern string GetTileUrl(string pano, int tileZoom, int tileX, int tileY);
    }
}
