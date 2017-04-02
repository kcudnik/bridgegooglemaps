namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    public delegate string GetTileUrlDelegate(Point tileCoord, int zoom);

    /// <summary>
    /// This class implements the MapType interface and is provided for
    /// rendering image tiles.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class ImageMapType : MVCObject, MapType
    {
        /// <summary>
        /// Constructs an ImageMapType using the provided ImageMapTypeOptions
        /// </summary>
        /// <param name="opts">
        /// The options.
        /// </param>
        public extern ImageMapType(ImageMapTypeOptions opts);

        /// <summary>
        /// Gets or sets the alt.
        /// </summary>
        public string Alt { get; set; }

        /// <summary>
        /// Gets or sets the max zoom.
        /// </summary>
        public int MaxZoom { get; set; }

        /// <summary>
        /// Gets or sets the min zoom.
        /// </summary>
        public int MinZoom { get; set; }

        /// <summary>
        /// Gets or sets the name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// Gets or sets the projection.
        /// </summary>
        public Projection Projection { get; set; }

        /// <summary>
        /// Gets or sets the radius.
        /// </summary>
        public double Radius { get; set; }

        /// <summary>
        /// Gets or sets the tile size.
        /// </summary>
        public Size TileSize { get; set; }

        /// <summary>
        /// Returns the opacity level (0 (transparent) to 1.0) of the
        /// ImageMapType tiles.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public extern double GetOpacity();

        /// <summary>
        /// The get tile.
        /// </summary>
        /// <param name="tileCoord">
        /// The tile coord.
        /// </param>
        /// <param name="zoom">
        /// The zoom.
        /// </param>
        /// <param name="ownerDocument">
        /// The owner document.
        /// </param>
        /// <returns>
        /// The <see cref="Node"/>.
        /// </returns>
        public extern Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        /// <summary>
        /// The release tile.
        /// </summary>
        /// <param name="tile">
        /// The tile.
        /// </param>
        public extern void ReleaseTile(Node tile);

        /// <summary>
        /// Sets the opacity level (0 (transparent) to 1.0) of the ImageMapType
        /// tiles.
        /// </summary>
        /// <param name="opacity">
        /// The opacity.
        /// </param>
        public extern void SetOpacity(double opacity);
    }
}
