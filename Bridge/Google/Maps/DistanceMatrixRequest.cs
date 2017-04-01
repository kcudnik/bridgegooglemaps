namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class DistanceMatrixRequest
    {
        public bool AvoidFerries;

        public bool AvoidHighways;

        public bool AvoidTolls;

        public Union<string[], LatLng[], Place[]> Destinations;

        public DrivingOptions DrivingOptions;

        public Union<string[], LatLng[], Place[]> Origins;

        public string Region;

        public TransitOptions TransitOptions;

        public  TravelMode TravelMode;

        public UnitSystem UnitSystem;
    }
}