namespace Bridge.Google.Maps.Geometry
{
    /// <summary>
    ///     Utilities for polyline encoding and decoding.
    /// </summary>
    [External]
    [Name("google.maps.geometry.encoding")]
    [Namespace(false)]
    public static class Encoding
    {
        /// <summary>
        ///     Decodes an encoded path string into a sequence of LatLngs.
        /// </summary>
        /// <param name="input">
        ///     The input.
        /// </param>
        /// <returns>
        ///     The path.
        /// </returns>
        public static extern LatLng[] DecodePath(string input);

        /// <summary>
        ///     Encodes a sequence of LatLngs into an encoded path string.
        /// </summary>
        /// <param name="path">
        ///     The path.
        /// </param>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public static extern string EncodePath(Union<MVCArray<LatLng>, LatLng[]> path);
    }
}