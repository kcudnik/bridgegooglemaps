namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The transit details.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class TransitDetails
    {
        /// <summary>
        ///     he arrival stop of this transit step.
        /// </summary>
        [Name("arrival_stop")]
        public TransitStop ArrivalStop;

        /// <summary>
        ///     The arrival time of this step, specified as a Time object.
        /// </summary>
        [Name("arrival_time")]
        public Time ArrivalTime;

        /// <summary>
        ///     The departure stop of this transit step.
        /// </summary>
        [Name("departure_stop")]
        public TransitStop DepartureStop;

        /// <summary>
        ///     The departure time of this step, specified as a Time object.
        /// </summary>
        [Name("departure_time")]
        public Time DepartureTime;

        /// <summary>
        ///     The direction in which to travel on this line, as it is marked on
        ///     the vehicle or at the departure stop.
        /// </summary>
        public string Headsign;

        /// <summary>
        ///     The expected number of seconds between equivalent vehicles at this
        ///     stop.
        /// </summary>
        public double Headway;

        /// <summary>
        ///     Details about the transit line used in this step.
        /// </summary>
        public TransitLine Line;

        /// <summary>
        ///     The number of stops on this step. Includes the arrival stop, but
        ///     not the departure stop.
        /// </summary>
        [Name("num_stops")]
        public int NumStops;
    }
}