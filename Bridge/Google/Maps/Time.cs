namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    /// <summary>
    /// The time.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Time
    {
        /// <summary>
        /// A string representing the time's value. The time is displayed in
        /// the time zone of the transit stop.
        /// </summary>
        public string Text;

        /// <summary>
        /// The time zone in which this stop lies. The value is the name of the
        /// time zone as defined in the IANA Time Zone Database, e.g.
        /// "America/New_York".
        /// </summary>
        [Name("time_zome")]
        public string TimeZone;

        /// <summary>
        /// The time of this departure or arrival, specified as a JavaScript
        /// Date object.
        /// </summary>
        public Date Value;
    }
}
