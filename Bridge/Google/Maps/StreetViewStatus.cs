namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The status returned by the StreetViewService on completion of a Street View request.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewStatus
    {
        /// <summary>
        /// The request was successful.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        /// The request could not be successfully processed, yet the exact reason for failure is unknown.
        /// </summary>
        [Name("UNKNOWN_ERROR")]
        UnknownError,

        /// <summary>
        /// There are no panoramas found that match the search criteria.
        /// </summary>
        [Name("ZERO_RESULTS")]
        ZeroResults
    }
}