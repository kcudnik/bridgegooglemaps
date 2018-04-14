namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The transit stop.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class TransitStop
    {
        /// <summary>
        ///     The location of this stop.
        /// </summary>
        public LatLng Location;

        /// <summary>
        ///     The name of this transit stop.
        /// </summary>
        public string Name;
    }
}