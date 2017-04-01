namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsWaypoint
    {
        public Union<string, LatLng, Place> Location;

        public bool Stopover;
    }
}