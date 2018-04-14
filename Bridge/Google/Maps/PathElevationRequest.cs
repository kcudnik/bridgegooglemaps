namespace Bridge.Google.Maps
{
    /// <summary>
    ///     An elevation query sent by the ElevationService containing the path
    ///     along which to return sampled data. This request defines a continuous
    ///     path along the earth along which elevation samples should be taken at
    ///     evenly-spaced distances. All paths from vertex to vertex use segments
    ///     of the great circle between those two points.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PathElevationRequest
    {
        /// <summary>
        ///     The path along which to collect elevation values.
        /// </summary>
        public LatLng[] Path;

        /// <summary>
        ///     Required. The number of equidistant points along the given path for
        ///     which to retrieve elevation data, including the endpoints. The
        ///     number of samples must be a value between 2 and 512 inclusive.
        /// </summary>
        public int Samples;
    }
}