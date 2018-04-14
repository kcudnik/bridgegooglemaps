namespace Bridge.Google.Maps.Geometry
{
    /// <summary>
    ///     Utility functions for computing geodesic angles, distances and areas.
    ///     The default radius is Earth's radius of 6378137 meters.
    /// </summary>
    [External]
    [Name("google.maps.geometry.spherical")]
    [Namespace(false)]
    public static class Spherical
    {
        /// <summary>
        ///     Returns the area of a closed path. The computed area uses the same
        ///     units as the radius. The radius defaults to the Earth's radius in
        ///     meters, in which case the area is in square meters.
        /// </summary>
        /// <param name="path">
        ///     The path.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public static extern double ComputeArea(Union<LatLng[], MVCArray<LatLng>> path, double radius = 0);

        /// <summary>
        ///     Returns the distance, in meters, between two LatLngs. You can
        ///     optionally specify a custom radius. The radius defaults to the
        ///     radius of the Earth.
        /// </summary>
        /// <param name="from">
        ///     The from.
        /// </param>
        /// <param name="to">
        ///     The to.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public static extern double ComputeDistanceBetween(LatLng from, LatLng to, double radius = 0);

        /// <summary>
        ///     Returns the heading from one LatLng to another LatLng. Headings are
        ///     expressed in degrees clockwise from North within the range
        ///     [-180,180).
        /// </summary>
        /// <param name="from">
        ///     The from.
        /// </param>
        /// <param name="to">
        ///     The to.
        /// </param>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public static extern double ComputeHeading(LatLng from, LatLng to);

        /// <summary>
        ///     Returns the length of the given path.
        /// </summary>
        /// <param name="array">
        ///     The array.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public static extern double ComputeLength(Union<LatLng[], MVCArray<LatLng>> array, double radius = 0);

        /// <summary>
        ///     Returns the LatLng resulting from moving a distance from an origin
        ///     in the specified heading (expressed in degrees clockwise from
        ///     north).
        /// </summary>
        /// <param name="from">
        ///     The from.
        /// </param>
        /// <param name="distance">
        ///     The distance.
        /// </param>
        /// <param name="heading">
        ///     The heading.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public static extern LatLng ComputeOffset(LatLng from, double distance, double heading, double radius = 0);

        /// <summary>
        ///     Returns the location of origin when provided with a LatLng
        ///     destination, meters travelled and original heading. Headings are
        ///     expressed in degrees clockwise from North. This function returns
        ///     null when no solution is available.
        /// </summary>
        /// <param name="to">
        ///     The to.
        /// </param>
        /// <param name="distance">
        ///     The distance.
        /// </param>
        /// <param name="heading">
        ///     The heading.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public static extern LatLng ComputeOffsetOrigin(LatLng to, double distance, double heading, double radius = 0);

        /// <summary>
        ///     Returns the signed area of a closed path. The signed area may be
        ///     used to determine the orientation of the path. The computed area
        ///     uses the same units as the radius. The radius defaults to the
        ///     Earth's radius in meters, in which case the area is in square
        ///     meters.
        /// </summary>
        /// <param name="loop">
        ///     The loop.
        /// </param>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public static extern double ComputeSignedArea(Union<LatLng[], MVCArray<LatLng>> loop, double radius = 0);

        /// <summary>
        ///     Returns the LatLng which lies the given fraction of the way between
        ///     the origin LatLng and the destination LatLng.
        /// </summary>
        /// <param name="from">
        ///     The from.
        /// </param>
        /// <param name="to">
        ///     The to.
        /// </param>
        /// <param name="fraction">
        ///     The fraction.
        /// </param>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public static extern LatLng Interpolate(LatLng from, LatLng to, double fraction);
    }
}