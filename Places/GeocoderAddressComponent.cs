namespace Bridge.Google.Maps.Places
{
    /// <summary>
    ///     A single address component within a GeocoderResult. A full address may
    ///     consist of multiple address components.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class GeocoderAddressComponent
    {
        /// <summary>
        ///     The full text of the address component.
        /// </summary>
        [Name("long_name")]
        public string LongName;

        /// <summary>
        ///     The abbreviated, short text of the given address component.
        /// </summary>
        [Name("short_name")]
        public string ShortName;

        /// <summary>
        ///     An array of strings denoting the type of this address component.
        ///     A list of valid types can be found
        ///     https://developers.google.com/maps/documentation/geocoding/#Types.
        /// </summary>
        public string[] Types;
    }
}