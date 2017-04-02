namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The valid unit systems that can be specified in a DirectionsRequest.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum UnitSystem
    {
        /// <summary>
        /// Specifies that distances in the DirectionsResult should be expressed in imperial units.
        /// </summary>
        [Name("IMPERIAL")]
        Imperial,

        /// <summary>
        /// Specifies that distances in the DirectionsResult should be expressed in metric units.
        /// </summary>
        [Name("METRIC")]
        Metric
    }
}
