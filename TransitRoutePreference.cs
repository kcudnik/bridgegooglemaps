namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The valid transit route type that can be specified in a TransitOptions.
    ///     Specify these by value, or by using the constant's name. For example,
    ///     'LESS_WALKING' or google.maps.TransitRoutePreference.LESS_WALKING.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TransitRoutePreference
    {
        /// <summary>
        ///     Specifies that the calculated route should prefer a limited number
        ///     of transfers.
        /// </summary>
        [Name("FEWER_TRANSFERS")]
        FewerTransfers,

        /// <summary>
        ///     Specifies that the calculated route should prefer limited amounts
        ///     of walking.
        /// </summary>
        [Name("LESS_WALKING")]
        LessWalking
    }
}