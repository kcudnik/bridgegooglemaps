namespace Bridge.Google.Maps
{
    using Html5;

    /// <summary>
    ///     Creates a MapType with a custom style.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StyledMapType : MVCObject, MapType
    {
        /// <summary>
        ///     Creates a styled MapType with the specified options. The
        ///     StyledMapType takes an array of MapTypeStyles, where each
        ///     MapTypeStyle is applied to the map consecutively. A later
        ///     MapTypeStyle that applies the same MapTypeStylers to the same
        ///     selectors as an earlier MapTypeStyle will override the earlier
        ///     MapTypeStyle.
        /// </summary>
        /// <param name="styles">The styles.</param>
        /// <param name="options">The options.</param>
        public extern StyledMapType(MapTypeStyle[] styles, StyledMapTypeOptions options = null);

        /// <summary>
        ///     Gets or sets the alt.
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        ///     Gets or sets the max zoom.
        /// </summary>
        public int MaxZoom { get; set; }

        /// <summary>
        ///     Gets or sets the min zoom.
        /// </summary>
        public int MinZoom { get; set; }

        /// <summary>
        ///     Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        ///     Gets or sets the projection.
        /// </summary>
        public Projection Projection { get; set; }

        /// <summary>
        ///     Gets or sets the radius.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        ///     Gets or sets the tile size.
        /// </summary>
        public Size TileSize { get; set; }

        /// <summary>
        ///     The get tile.
        /// </summary>
        /// <param name="tileCoord">
        ///     The tile coord.
        /// </param>
        /// <param name="zoom">
        ///     The zoom.
        /// </param>
        /// <param name="ownerDocument">
        ///     The owner document.
        /// </param>
        /// <returns>
        ///     The <see cref="Node" />.
        /// </returns>
        public extern Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        /// <summary>
        ///     The release tile.
        /// </summary>
        /// <param name="tile">
        ///     The tile.
        /// </param>
        public extern void ReleaseTile(Node tile);
    }
}