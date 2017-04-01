namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [Namespace("google.maps")]
    public class StyledMapType : MVCObject, MapType
    {
        public string Alt { get; set;}

        public int MaxZoom { get; set;}

        public int MinZoom { get; set;}

        public string Name { get; set;}

        public Projection Projection { get; set;}

        public double Radius { get; set;}

        public Size TileSize { get; set;}

        public extern StyledMapType(MapTypeStyle[] styles, StyledMapTypeOptions options = null);

        // public extern GetTileDelegate GetTile { get; set; }
        public extern Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        public extern void ReleaseTile(Node tile);
    }
}