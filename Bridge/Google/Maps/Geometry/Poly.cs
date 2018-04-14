namespace Bridge.Google.Maps.Geometry
{
    /// <summary>
    ///     Utility functions for computations involving polygons and polylines.
    /// </summary>
    [External]
    [Name("google.maps.geometry.poly")]
    [Namespace(false)]
    public static class Poly
    {
        /// <summary>
        ///     Computes whether the given point lies inside the specified polygon.
        /// </summary>
        /// <param name="location">
        ///     The location.
        /// </param>
        /// <param name="poly">
        ///     The poly.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public static extern bool ContainsLocation(LatLng location, Polygon poly);

        /// <summary>
        ///     Computes whether the given point lies on or near to a polyline, or
        ///     the edge of a polygon, within a specified tolerance. Returns true
        ///     when the difference between the latitude and longitude of the
        ///     supplied point, and the closest point on the edge, is less than the
        ///     tolerance. The tolerance defaults to 10-9 degrees.
        /// </summary>
        /// <param name="point">
        ///     The point.
        /// </param>
        /// <param name="poly">
        ///     The poly.
        /// </param>
        /// <param name="tolerance">
        ///     The tolerance.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public static extern bool IsLocationOnEdge(LatLng point, Union<Polygon, Polyline> poly, double tolerance = 0);
    }
}