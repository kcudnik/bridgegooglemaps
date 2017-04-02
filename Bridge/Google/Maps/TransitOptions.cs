namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    /// <summary>
    /// The TransitOptions object to be included in a DirectionsRequest when the travel mode is set to TRANSIT.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class TransitOptions
    {
        /// <summary>
        /// The desired arrival time for the route, specified as a Date object. The Date object measures time in milliseconds since 1 January 1970. If arrival time is specified, departure time is ignored.
        /// </summary>
        public Date ArrivalTime;

        /// <summary>
        /// The desired departure time for the route, specified as a Date object. The Date object measures time in milliseconds since 1 January 1970. If neither departure time nor arrival time is specified, the time is assumed to be "now".
        /// </summary>
        public Date DepatrureTime;

        /// <summary>
        /// One or more preferred modes of transit, such as bus or train. If no preference is given, the API returns the default best route.
        /// </summary>
        public TransitMode[] Modes;

        /// <summary>
        /// A preference that can bias the choice of transit route, such as less walking. If no preference is given, the API returns the default best route.
        /// </summary>
        public TransitRoutePreference RoutingPreference;
    }
}