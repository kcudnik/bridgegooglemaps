namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A directions query to be sent to the DirectionsService.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsRequest
    {
        /// <summary>
        /// If true, instructs the Directions service to avoid ferries where
        /// possible. Optional.
        /// </summary>
        public bool AvoidFerries;

        /// <summary>
        /// If true, instructs the Directions service to avoid highways where
        /// possible. Optional.
        /// </summary>
        public bool AvoidHighways;

        /// <summary>
        /// If true, instructs the Directions service to avoid toll roads where
        /// possible. Optional.
        /// </summary>
        public bool AvoidTolls;

        /// <summary>
        /// Location of destination. This can be specified as either a string
        /// to be geocoded, or a LatLng, or a Place. Required.
        /// </summary>
        public Union<string, LatLng, Place> Destination;

        /// <summary>
        /// Settings that apply only to requests where travelMode is DRIVING.
        /// This object will have no effect for other travel modes.
        /// </summary>
        public DrivingOptions DrivingOptions;

        /// <summary>
        /// If set to true, the DirectionService will attempt to re-order the
        /// supplied intermediate waypoints to minimize overall cost of the
        /// route. If waypoints are optimized, inspect
        /// DirectionsRoute.waypoint_order in the response to determine the new
        /// ordering.
        /// </summary>
        public bool OptimizeWaypoints;

        /// <summary>
        /// Location of origin. This can be specified as either a string to be
        /// geocoded, or a LatLng, or a Place. Required
        /// </summary>
        public Union<string, LatLng, Place> Origin;

        /// <summary>
        /// Whether or not route alternatives should be provided. Optional.
        /// </summary>
        public bool ProvideRouteAlternatives;

        /// <summary>
        /// Region code used as a bias for geocoding requests. Optional.
        /// </summary>
        public string Region;

        /// <summary>
        /// Settings that apply only to requests where travelMode is TRANSIT.
        /// This object will have no effect for other travel modes.
        /// </summary>
        public TransitOptions TransitOptions;

        /// <summary>
        /// Type of routing requested. Required.
        /// </summary>
        public TravelMode TravelMode;

        /// <summary>
        /// Preferred unit system to use when displaying distance. Defaults to
        /// the unit system used in the country of origin.
        /// </summary>
        public UnitSystem UnitSystem;

        /// <summary>
        /// Array of intermediate waypoints. Directions will be calculated from
        /// the origin to the destination by way of each waypoint in this
        /// array. The maximum allowed waypoints is 8, plus the origin, and
        /// destination. Maps API for Work customers are allowed 23 waypoints,
        /// plus the origin, and destination. Waypoints are not supported for
        /// transit directions. Optional.
        /// </summary>
        public DirectionsWaypoint[] Waypoints;
    }
}
