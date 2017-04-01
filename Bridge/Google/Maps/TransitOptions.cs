namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    [External]
    [ObjectLiteral]
    public class TransitOptions
    {
        public Date ArrivalTime;

        public Date DepatrureTime;

        public TransitMode[] Modes;

        public TransitRoutePreference RoutingPreference;
    }
}