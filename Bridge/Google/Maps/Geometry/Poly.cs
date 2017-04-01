namespace Bridge.Google.Maps.Geometry
{
    using Bridge;

    [External]
    [Name("google.maps.geometry.poly")]
    [Namespace(false)]
    public static class Poly
    {
        public extern static bool ContainsLocation(LatLng location, Polygon poly);

        public extern static bool IsLocationOnEdge(LatLng point, Union<Polygon, Polyline> poly, double tolerance = 0);
    }
}