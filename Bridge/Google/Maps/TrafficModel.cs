namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The assumptions to use when predicting duration in traffic. Specified as part of a DirectionsRequest or DistanceMatrixRequest.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TrafficModel
    {
        /// <summary>
        /// Use historical traffic data to best estimate the time spent in traffic.
        /// </summary>
        [Name("BEST_GUESS")]
        BestGuess,

        /// <summary>
        /// Use historical traffic data to make an optimistic estimate of what the duration in traffic will be.
        /// </summary>
        [Name("OPTIMISTIC")]
        Optimistic,

        /// <summary>
        /// Use historical traffic data to make an optimistic estimate of what the duration in traffic will be.
        /// </summary>
        [Name("PESSIMISTIC")]
        Pesimistic
    }
}
