namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// This class is used to create a MapType that renders image tiles.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class ImageMapTypeOptions
    {
        /// <summary>
        /// Alt text to display when this MapType's button is hovered over in
        /// the MapTypeControl.
        /// </summary>
        public string Alt;

        /// <summary>
        /// Returns a string (URL) for given tile coordinate (x, y) and zoom
        /// level.
        /// </summary>
        public GetTileUrlDelegate GetTileUrl;

        /// <summary>
        /// The maximum zoom level for the map when displaying this MapType.
        /// </summary>
        public int MaxZoom;

        /// <summary>
        /// The minimum zoom level for the map when displaying this MapType.
        /// Optional.
        /// </summary>
        public int MinZoom;

        /// <summary>
        /// Name to display in the MapTypeControl.
        /// </summary>
        public string Name;

        /// <summary>
        /// The opacity to apply to the tiles. The opacity should be specified
        /// as a float value between 0 and 1.0, where 0 is fully transparent
        /// and 1 is fully opaque.
        /// </summary>
        public double Opacity;

        /// <summary>
        /// The tile size.
        /// </summary>
        public Size TileSize;
    }
}
