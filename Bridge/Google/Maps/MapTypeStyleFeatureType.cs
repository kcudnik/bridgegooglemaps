namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Possible values for feature types. Specify these values as strings, i.e. 'administrative' or 'poi.park'. Stylers applied to a parent feature type automatically apply to all child feature types. Note however that parent features may include some additional features that are not included in one of their child feature types.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    public enum MapTypeStyleFeatureType
    {
        /// <summary>
        /// Apply the rule to administrative areas.
        /// </summary>
        [Name("administrative")]
        Administrative,

        /// <summary>
        /// Apply the rule to all selector types.
        /// </summary>
        [Name("all")]
        All,

        // TODO populate
    }
}
