namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A single leg consisting of a set of steps in a DirectionsResult.
    /// Some fields in the leg may not be returned for all requests.
    /// Note that though this result is "JSON-like," it is not strictly JSON,
    /// as it directly and indirectly includes LatLng objects.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsLeg
    {
        /// <summary>
        /// An estimated arrival time for this leg. Only applicable for TRANSIT
        /// requests.
        /// </summary>
        [Name("arrival_time")]
        public Time ArrivalTime;

        /// <summary>
        /// An estimated departure time for this leg. Only applicable for
        /// TRANSIT requests.
        /// </summary>
        [Name("departure_time")]
        public Time DepartureTime;

        /// <summary>
        /// The total distance covered by this leg. This property may be
        /// undefined as the distance may be unknown.
        /// </summary>
        public Distance Distance;

        /// <summary>
        /// The total duration of this leg. This property may be undefined as
        /// the duration may be unknown.
        /// </summary>
        public Duration Duration;

        /// <summary>
        /// The total duration of this leg, taking into account the traffic
        /// conditions indicated by the trafficModel property. This property
        /// may be undefined as the duration may be unknown. Only available to
        /// Maps for Work customers when drivingOptions is defined when making
        /// the request.
        /// </summary>
        [Name("duration_in_traffic")]
        public Duration DurationInTraffic;

        /// <summary>
        /// The address of the destination of this leg.
        /// </summary>
        [Name("end_address")]
        public string EndAddress;

        /// <summary>
        /// The DirectionsService calculates directions between locations by
        /// using the nearest transportation option (usually a road) at the
        /// start and end locations. end_location indicates the actual geocoded
        /// destination, which may be different than the end_location of the
        /// last step if, for example, the road is not near the destination of
        /// this leg.
        /// </summary>
        [Name("end_location")]
        public LatLng EndLocation;

        /// <summary>
        /// The address of the origin of this leg.
        /// </summary>
        [Name("start_address")]
        public string StartAddress;

        /// <summary>
        /// The DirectionsService calculates directions between locations by
        /// using the nearest transportation option (usually a road) at the
        /// start and end locations. start_location indicates the actual
        /// geocoded origin, which may be different than the start_location of
        /// the first step if, for example, the road is not near the origin of
        /// this leg.
        /// </summary>
        [Name("start_location")]
        public LatLng StartLocation;

        /// <summary>
        /// An array of DirectionsSteps, each of which contains information
        /// about the individual steps in this leg.
        /// </summary>
        public DirectionsStep[] Steps;

        /// <summary>
        /// An array of waypoints along this leg that were not specified in the
        /// original request, either as a result of a user dragging the
        /// polyline or selecting an alternate route.
        /// </summary>
        [Name("via_waypoints")]
        public LatLng[] ViaWaypoints;
    }
}
