namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A representation of duration as a numeric value and a display string.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Duration
    {
        /// <summary>
        /// A string representation of the duration value.
        /// </summary>
        public string Text;

        /// <summary>
        /// The duration in seconds.
        /// </summary>
        public int Value;
    }
}