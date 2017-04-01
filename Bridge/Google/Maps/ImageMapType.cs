namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    public delegate string GetTileUrlDelegate(Point tileCoord, int zoom);

    [External]
    [Namespace("google.maps")]
    public class ImageMapType : MVCObject, MapType
    {
        public string Alt { get; set;}

        public int MaxZoom { get; set;}

        public int MinZoom { get; set;}

        public string Name { get; set;}

        public Projection Projection { get; set;}

        public double Radius { get; set;}

        public Size TileSize { get; set;}

        public extern ImageMapType(ImageMapTypeOptions opts);

        public extern double GetOpacity();

        // TODO could be method
        //public extern GetTileDelegate GetTile { get; set; }
        public extern Node GetTile(Point tileCoord, int zoom, DocumentInstance ownerDocument);

        public extern void ReleaseTile(Node tile);

        public extern void SetOpacity(double opacity);
    }
}