namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A representation of distance as a numeric value and a display string.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Distance
    {
        /// <summary>
        ///     A string representation of the distance value, using the UnitSystem
        ///     specified in the request.
        /// </summary>
        public string Text;

        /// <summary>
        ///     The distance in meters.
        /// </summary>
        public double Value;
    }
}