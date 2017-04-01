namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MarkerPlace
    {
        public Union<LatLng, LatLngLiteral> Location;

        public string PlaceId;

        public string Query;
    }
}