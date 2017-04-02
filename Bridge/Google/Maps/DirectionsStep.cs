namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A single DirectionsStep in a DirectionsResult. Some fields may be
    /// undefined. Note that though this object is "JSON-like," it is not
    /// strictly JSON, as it directly includes LatLng objects.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsStep
    {
        /// <summary>
        /// The distance covered by this step. This property may be undefined
        /// as the distance may be unknown.
        /// </summary>
        public Distance Distance;

        /// <summary>
        /// The typical time required to perform this step in seconds and in
        /// text form. This property may be undefined as the duration may be
        /// unknown.
        /// </summary>
        public Duration Duration;

        /// <summary>
        /// The ending location of this step.
        /// </summary>
        [Name("end_location")]
        public LatLng EndLocation;

        /// <summary>
        /// Instructions for this step.
        /// </summary>
        public string Instructions;

        /// <summary>
        /// A sequence of LatLngs describing the course of this step.
        /// </summary>
        public LatLng[] Path;

        /// <summary>
        /// The starting location of this step.
        /// </summary>
        [Name("start_location")]
        public LatLng StartLocation;

        /// <summary>
        /// Sub-steps of this step. Specified for non-transit sections of
        /// transit routes.
        /// </summary>
        public DirectionsStep[] Steps;

        /// <summary>
        /// Transit-specific details about this step. This property will be
        /// undefined unless the travel mode of this step is TRANSIT.
        /// </summary>
        public TransitDetails Transit;

        /// <summary>
        /// The mode of travel used in this step.
        /// </summary>
        public TravelMode TravelMode;
    }
}
