namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DirectionsRequest
    {
        public bool AvoidFerries;

        public bool AvoidHighways;

        public bool AvoidTolls;

        public Union<string, LatLng, Place> Destination;

        public DrivingOptions DrivingOptions;

        public bool OptimizeWaypoints;

        public Union<string, LatLng, Place> Origin;

        public bool ProvideRouteAlternatives;

        public string Region;

        public TransitOptions TransitOptions;

        public TravelMode TravelMode;

        public UnitSystem UnitSystem;

        public DirectionsWaypoint[] Waypoints;
    }
}