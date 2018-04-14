namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The result of an ElevationService request, consisting of the set of
    ///     elevation coordinates and their elevation values. Note that a single
    ///     request may produce multiple ElevationResults.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class ElevationResult
    {
        /// <summary>
        ///     The elevation of this point on Earth, in meters above sea level.
        /// </summary>
        public double Elevation;

        /// <summary>
        ///     The location of this elevation result.
        /// </summary>
        public LatLng Location;

        /// <summary>
        ///     The distance, in meters, between sample points from which the
        ///     elevation was interpolated. This property will be missing if the
        ///     resolution is not known. Note that elevation data becomes more
        ///     coarse (larger resolution values) when multiple points are passed.
        ///     To obtain the most accurate elevation value for a point, it should
        ///     be queried independently.
        /// </summary>
        public double Resolution;
    }
}