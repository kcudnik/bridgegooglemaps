namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class StreetViewLocationRequest
    {
        public Union<LatLng, LatLngLiteral> Location;

        public  StreetViewPreference Preference;

        public double Radius;

        public StreetViewSource Source;
    }
}