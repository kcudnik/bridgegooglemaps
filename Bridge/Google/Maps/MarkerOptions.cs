namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MarkerOptions
    {
        public Point AnchorPoint;

        public Animation Animation;

        public Attribution Attribution;

        public bool Clickable;

        public bool CrossOnDrag;

        public string Cursor;

        public bool Draggable;

        public Union<string, Icon, Symbol> Icon;

        public Union<string, MarkerLabel> Label;

        public Union<Map, StreetViewPanorama> Map;

        public double Opacity;

        public bool Optimized;

        public MarkerPlace Place;

        public LatLng Position;

        public string Title;

        public bool Visible;

        public int ZIndex;
    }
}