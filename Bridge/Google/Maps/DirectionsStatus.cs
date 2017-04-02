namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The status returned by the DirectionsService on the completion of a call to route().
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum DirectionsStatus
    {
        /// <summary>
        /// The DirectionsRequest provided was invalid.
        /// </summary>
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        /// <summary>
        /// Too many DirectionsWaypoints were provided in the DirectionsRequest. The total allowed waypoints is 8, plus the origin and destination. Maps API for Work customers are allowed 23 waypoints, plus the origin, and destination.
        /// </summary>
        [Name("MAX_WAYPOINTS_EXCEEDED")]
        MaxWaypointsExceeded,

        /// <summary>
        /// At least one of the origin, destination, or waypoints could not be geocoded.
        /// </summary>
        [Name("NOT_FOUND")]
        NotFound,

        /// <summary>
        /// The response contains a valid DirectionsResult.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        /// The webpage has gone over the requests limit in too short a period of time.
        /// </summary>
        [Name("OVER_QUERY_LIMIT")]
        OverQueryLimit,

        /// <summary>
        /// The webpage is not allowed to use the directions service.
        /// </summary>
        [Name("REQUEST_DENIED")]
        RequestDenied,

        /// <summary>
        /// A directions request could not be processed due to a server error. The request may succeed if you try again.
        /// </summary>
        [Name("UNKNOWN_ERROR")]
        UnknownError,

        /// <summary>
        /// No route could be found between the origin and destination.
        /// </summary>
        [Name("ZERO_RESULTS")]
        ZeroResults,
    }
}
