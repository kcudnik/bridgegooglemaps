namespace Bridge.Google.Maps
{
    using Html5;

    /// <summary>
    ///     Configures the DirectionsRequest when the travel mode is set to
    ///     DRIVING.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DrivingOptions
    {
        /// <summary>
        ///     The desired departure time for the route, specified as a Date
        ///     object. The Date object measures time in milliseconds since 1
        ///     January 1970. This must be specified for a DrivingOptions to be
        ///     valid. The departure time must be set to the current time or some
        ///     time in the future. It cannot be in the past.
        /// </summary>
        public Date DepartureTime;

        /// <summary>
        ///     The preferred assumption to use when predicting duration in
        ///     traffic. The default is BEST_GUESS.
        /// </summary>
        public TrafficModel TrafficModel;
    }
}