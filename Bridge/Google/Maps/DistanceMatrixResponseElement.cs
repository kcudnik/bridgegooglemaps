namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A single element of a response to a DistanceMatrixService request,
    ///     which contains the duration and distance from one origin to one
    ///     destination.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DistanceMatrixResponseElement
    {
        /// <summary>
        ///     The distance for this origin-destination pairing. This property may
        ///     be undefined as the distance may be unknown.
        /// </summary>
        public Distance Distance;

        /// <summary>
        ///     The duration for this origin-destination pairing. This property may
        ///     be undefined as the duration may be unknown.
        /// </summary>
        public Duration Duration;

        /// <summary>
        ///     The duration for this origin-destination pairing, taking into
        ///     account the traffic conditions indicated by the trafficModel
        ///     property. This property may be undefined as the duration may be
        ///     unknown. Only available to Maps for Work customers when
        ///     drivingOptions is defined when making the request.
        /// </summary>
        [Name("duration_in_traffic")]
        public Duration DurationInTraffic;

        /// <summary>
        ///     The total fare for this origin-destination pairing. Only applicable
        ///     to transit requests.
        /// </summary>
        public TransitFare Fare;

        /// <summary>
        ///     The status of this particular origin-destination pairing.
        /// </summary>
        public DistanceMatrixElementStatus Status;
    }
}