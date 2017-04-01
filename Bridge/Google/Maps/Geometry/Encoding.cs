namespace Bridge.Google.Maps.Geometry
{
    using Bridge;

    [External]
    [Name("google.maps.geometry.encoding")]
    [Namespace(false)]
    public static class Encoding
    {
        public extern static LatLng[] DecodePath(string input);

        public extern static string EncodePath(Union<MVCArray<LatLng>, LatLng[]> path);
    }
}