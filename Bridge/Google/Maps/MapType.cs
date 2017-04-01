namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    public delegate Node GetTileDelegate(Point tileCoord, int zoom, DocumentInstance ownerDocument);

    [External]
    [ExternalInterface]
    public interface MapType
    {
        // TODO we need to bring back FieldProperty

        [Name("alt")]
        string Alt { get; set;}

        [Name("maxZoom")]
        int MaxZoom { get; set;}

        [Name("minZoom")]
        int MinZoom { get; set;}

        [Name("name")]
        string Name { get; set;}

        [Name("projection")]
        Projection Projection { get; set;}

        [Name("radius")]
        double Radius { get; set;}

        [Name("tileSize")]
        Size TileSize { get; set;}

        // TODO could be method
        //GetTileDelegate GetTile { get; set; }
        Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        void ReleaseTile(Node tile);
    }
}