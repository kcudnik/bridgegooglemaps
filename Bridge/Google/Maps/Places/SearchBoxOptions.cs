namespace Bridge.Google.Maps.Places
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class SearchBoxOptions
    {
        public Union<LatLngBounds, LatLngBoundsLiteral> Bounds;
    }
}