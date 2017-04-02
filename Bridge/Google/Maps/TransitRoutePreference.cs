namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The valid transit route type that can be specified in a TransitOptions.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TransitRoutePreference
    {
        /// <summary>
        /// Specifies that the calculated route should prefer a limited number of transfers.
        /// </summary>
        [Name("FEWER_TRANSFERS")]
        FewerTransfers,

        /// <summary>
        /// Specifies that the calculated route should prefer limited amounts of walking.
        /// </summary>
        [Name("LESS_WALKING")]
        LessWalking
    }
}
