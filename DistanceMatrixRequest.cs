namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A distance matrix query sent by the DistanceMatrixService containing
    ///     arrays of origin and destination locations, and various options for
    ///     computing metrics.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DistanceMatrixRequest
    {
        /// <summary>
        ///     If true, instructs the Distance Matrix service to avoid ferries
        ///     where possible. Optional.
        /// </summary>
        public bool AvoidFerries;

        /// <summary>
        ///     If true, instructs the Distance Matrix service to avoid highways
        ///     where possible. Optional.
        /// </summary>
        public bool AvoidHighways;

        /// <summary>
        ///     If true, instructs the Distance Matrix service to avoid toll roads
        ///     where possible. Optional.
        /// </summary>
        public bool AvoidTolls;

        /// <summary>
        ///     An array containing destination address strings, or LatLng, or
        ///     Place objects, to which to calculate distance and time. Required.
        /// </summary>
        public Union<string[], LatLng[], Place[]> Destinations;

        /// <summary>
        ///     Settings that apply only to requests where travelMode is DRIVING.
        ///     This object will have no effect for other travel modes.
        /// </summary>
        public DrivingOptions DrivingOptions;

        /// <summary>
        ///     An array containing origin address strings, or LatLng, or Place
        ///     objects, from which to calculate distance and time. Required.
        /// </summary>
        public Union<string[], LatLng[], Place[]> Origins;

        /// <summary>
        ///     Region code used as a bias for geocoding requests. Optional.
        /// </summary>
        public string Region;

        /// <summary>
        ///     Settings that apply only to requests where travelMode is TRANSIT.
        ///     This object will have no effect for other travel modes.
        /// </summary>
        public TransitOptions TransitOptions;

        /// <summary>
        ///     Type of routing requested. Required.
        /// </summary>
        public TravelMode TravelMode;

        /// <summary>
        ///     Preferred unit system to use when displaying distance. Optional;
        ///     defaults to metric.
        /// </summary>
        public UnitSystem UnitSystem;
    }
}