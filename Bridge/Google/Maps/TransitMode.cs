namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The valid transit mode e.g. bus that can be specified in a
    /// TransitOptions. Specify these by value, or by using the constant's
    /// name. For example, 'BUS' or google.maps.TransitMode.BUS.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TransitMode
    {
        /// <summary>
        /// Specifies bus as a preferred mode of transit.
        /// </summary>
        [Name("BUS")]
        Bus,

        /// <summary>
        /// Specifies rail as a preferred mode of transit.
        /// </summary>
        [Name("RAIL")]
        Rail,

        /// <summary>
        /// Specifies subway as a preferred mode of transit.
        /// </summary>
        [Name("SUBWAY")]
        Subway,

        /// <summary>
        /// Specifies train as a preferred mode of transit.
        /// </summary>
        [Name("TRAIN")]
        Train,

        /// <summary>
        /// Specifies tram as a preferred mode of transit.
        /// </summary>
        [Name("TRAM")]
        Tram,
    }
}
