namespace Bridge.Google.Maps
{
    using Html5;

    /// <summary>
    ///     Get tile delegate.
    /// </summary>
    [External]
    public delegate Node GetTileDelegate(Point tileCoord, int zoom, DocumentInstance ownerDocument);

    /// <summary>
    ///     This interface defines the map type, and is typically used for custom
    ///     map types. Immutable.
    /// </summary>
    [External]
    [Name("Object")]
    [Convention(Notation.LowerCamelCase, ConventionTarget.Member)]
    public interface MapType
    {
        /// <summary>
        ///     Alt text to display when this MapType's button is hovered over in
        ///     the MapTypeControl. Optional.
        /// </summary>
        string Alt { get; set; }

        /// <summary>
        ///     The maximum zoom level for the map when displaying this MapType.
        ///     Required for base MapTypes, ignored for overlay MapTypes.
        /// </summary>
        int MaxZoom { get; set; }

        /// <summary>
        ///     The minimum zoom level for the map when displaying this MapType.
        ///     Optional; defaults to 0.
        /// </summary>
        int MinZoom { get; set; }

        /// <summary>
        ///     Name to display in the MapTypeControl. Optional.
        /// </summary>
        string Name { get; set; }

        /// <summary>
        ///     The Projection used to render this MapType. Optional; defaults to
        ///     Mercator.
        /// </summary>
        Projection Projection { get; set; }

        /// <summary>
        ///     Radius of the planet for the map, in meters. Optional; defaults to
        ///     Earth's equatorial radius of 6378137 meters.
        /// </summary>
        double Radius { get; set; }

        /// <summary>
        ///     The dimensions of each tile. Required.
        /// </summary>
        Size TileSize { get; set; }

        /// <summary>
        ///     Returns a tile for the given tile coordinate (x, y) and zoom level.
        ///     This tile will be appended to the given ownerDocument. Not
        ///     available for base map types.
        /// </summary>
        /// <param name="tileCoord">
        ///     The tile Coord.
        /// </param>
        /// <param name="zoom">
        ///     The zoom.
        /// </param>
        /// <param name="ownerDocument">
        ///     The owner Document.
        /// </param>
        /// <returns>
        ///     The tile Node.
        /// </returns>
        Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        /// <summary>
        ///     Releases the given tile, performing any necessary cleanup. The
        ///     provided tile will have already been removed from the document.
        ///     Optional.
        /// </summary>
        /// <param name="tile">
        ///     The tile.
        /// </param>
        void ReleaseTile(Node tile);
    }
}