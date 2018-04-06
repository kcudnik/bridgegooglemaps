namespace Bridge.Google.Maps
{
    using Bridge;

    // TODO not enum but string

    /// <summary>
    /// The element-level status about a particular origin-destination pairing
    /// returned by the DistanceMatrixService upon completion of a distance
    /// matrix request.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DistanceMatrixElementStatus
    {
        /// <summary>
        /// The origin and/or destination of this pairing could not be
        /// geocoded.
        /// </summary>
        [Name("NOT_FOUND")]
        NotFound,

        /// <summary>
        /// The response contains a valid result.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        /// No route could be found between the origin and destination.
        /// </summary>
        [Name("ZERO_RESULTS")]
        ZeroResults
    }
}
