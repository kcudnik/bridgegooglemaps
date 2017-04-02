namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The status returned by the ElevationService upon completion of an
    /// elevation requerst.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ElevationStatus
    {
        /// <summary>
        /// This request was invalid.
        /// </summary>
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        /// <summary>
        /// The request did not encounter any errors.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        /// The webpage has gone over the requests limit in too short a period
        /// of time.
        /// </summary>
        [Name("OVER_QUERY_LIMIT")]
        OverQueryLimit,

        /// <summary>
        /// The webpage is not allowed to use the elevation service for some
        /// reason.
        /// </summary>
        [Name("REQUEST_DENIED")]
        RequestDenied,

        /// <summary>
        /// A geocoding, directions or elevation request could not be
        /// successfully processed, yet the exact reason for the failure is not
        /// known.
        /// </summary>
        [Name("UNKNOWN_ERROR")]
        UnknownError
    }
}
