namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The top-level status about the request in general returned by the
    ///     DistanceMatrixService upon completion of a distance matrix request.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DistanceMatrixStatus
    {
        /// <summary>
        ///     The provided request was invalid.
        /// </summary>
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        /// <summary>
        ///     The request contains more than 25 origins, or more than 25
        ///     destinations.
        /// </summary>
        [Name("MAX_DIMENSIONS_EXCEEDED")]
        MaxDimensionsExceeded,

        /// <summary>
        ///     The product of origins and destinations exceeds the per-query
        ///     limit.
        /// </summary>
        [Name("MAX_ELEMENTS_EXCEEDED")]
        MaxElementsExceeded,

        /// <summary>
        ///     The response contains a valid result.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        ///     Too many elements have been requested within the allowed time
        ///     period. The request should succeed if you try again after a
        ///     reasonable amount of time.
        /// </summary>
        [Name("OVER_QUERY_LIMIT")]
        OverQueryLimit,

        /// <summary>
        ///     The service denied use of the Distance Matrix service by your web
        ///     page.
        /// </summary>
        [Name("REQUEST_DENIED")]
        RequestDenied,

        /// <summary>
        ///     A Distance Matrix request could not be processed due to a server
        ///     error. The request may succeed if you try again.
        /// </summary>
        [Name("UNKNOWN_ERROR")]
        UnknownError
    }
}