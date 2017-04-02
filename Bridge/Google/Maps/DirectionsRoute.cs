namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A single route containing a set of legs in a DirectionsResult.
    /// Note that though this object is "JSON-like," it is not strictly JSON, as it directly and indirectly includes LatLng objects.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsRoute
    {
        /// <summary>
        /// The bounds for this route.
        /// </summary>
        public LatLngBounds Bounds;

        /// <summary>
        /// Copyrights text to be displayed for this route.
        /// </summary>
        public string Copyrights;

        /// <summary>
        /// The total fare for the whole transit trip. Only applicable to transit requests.
        /// </summary>
        public TransitFare Fare;

        /// <summary>
        /// An array of DirectionsLegs, each of which contains information about the steps of which it is composed. There will be one leg for each waypoint or destination specified. So a route with no waypoints will contain one DirectionsLeg and a route with one waypoint will contain two.
        /// </summary>
        public DirectionsLeg[] Legs;

        /// <summary>
        /// An array of LatLngs representing the entire course of this route. The path is simplified in order to make it suitable in contexts where a small number of vertices is required (such as Static Maps API URLs).
        /// </summary>
        [Name("overview_path")]
        public LatLng[] OverviewPath;

        /// <summary>
        /// An encoded polyline representation of the route in overview_path. This polyline is an approximate (smoothed) path of the resulting directions.
        /// </summary>
        [Name("overview_polyline")]
        public string OverviewPolyline;

        /// <summary>
        /// Warnings to be displayed when showing these directions.
        /// </summary>
        public string[] Warnings;

        /// <summary>
        /// If optimizeWaypoints was set to true, this field will contain the re-ordered permutation of the input waypoints. For example, if the input was:
        /// Origin: Los Angeles
        /// Waypoints: Dallas, Bangor, Phoenix
        /// Destination: New York
        /// and the optimized output was ordered as follows:
        /// Origin: Los Angeles
        /// Waypoints: Phoenix, Dallas, Bangor
        /// Destination: New York
        /// then this field will be an Array containing the values [2, 0, 1]. Note that the numbering of waypoints is zero-based.
        /// If any of the input waypoints has stopover set to false, this field will be empty, since route optimization is not available for such queries.
        /// </summary>
        [Name("waypoint_order")]
        public int[] WaypointOrder;
    }
}