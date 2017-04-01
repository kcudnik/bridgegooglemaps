namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [ObjectLiteral]
    public class Time
    {
        public string Text;

        [Name("time_zome")]
        public string TimeZone;

        public Date Value;
    }
}