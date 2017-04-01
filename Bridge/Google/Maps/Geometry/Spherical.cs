namespace Bridge.Google.Maps.Geometry
{
    using Bridge;

    [External]
    [Name("google.maps.geometry.spherical")]
    [Namespace(false)]
    public static class Spherical
    {
        public extern static double ComputeDistanceBetween(LatLng from, LatLng to, double radius = 0);

        public extern static double ComputeLength(LatLng[] array, double radius = 0);

        public extern static double ComputeLength(MVCArray<LatLng> array, double radius = 0);

        public extern static LatLng ComputeOffset(LatLng from, double distance, double heading, double radius = 0);
    }
}