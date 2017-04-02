namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A DirectionsWaypoint represents a location between origin and destination through which the trip should be routed.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsWaypoint
    {
        /// <summary>
        /// Waypoint location. Can be an address string, a LatLng, or a Place. Optional.
        /// </summary>
        public Union<string, LatLng, Place> Location;

        /// <summary>
        /// If true, indicates that this waypoint is a stop between the origin and destination. This has the effect of splitting the route into two. This value is true by default. Optional.
        /// </summary>
        public bool Stopover;
    }
}