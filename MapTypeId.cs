namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Identifiers for common MapTypes. Specify these by value, or by using
    ///     the constant's name. For example, 'satellite' or
    ///     google.maps.MapTypeId.SATELLITE.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeId
    {
        /// <summary>
        ///     This map type displays a transparent layer of major streets on
        ///     satellite images.
        /// </summary>
        [Name("HYBRID")]
        Hybrid,

        /// <summary>
        ///     This map type displays a normal street map.
        /// </summary>
        [Name("ROADMAP")]
        Roadmap,

        /// <summary>
        ///     This map type displays satellite images.
        /// </summary>
        [Name("SATELLITE")]
        Satellite,

        /// <summary>
        ///     This map type displays maps with physical features such as terrain
        ///     and vegetation.
        /// </summary>
        [Name("TERRAIN")]
        Terrain
    }
}