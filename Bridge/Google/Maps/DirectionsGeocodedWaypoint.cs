namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The directions geocoded waypoint.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DirectionsGeocodedWaypoint
    {
        /// <summary>
        /// Whether the geocoder did not return an exact match for the original waypoint, though it was able to match part of the requested address.
        /// </summary>
        [Name("partial_match")]
        public bool PartialMatch;

        /// <summary>
        /// The place ID associated with the waypoint. Place IDs uniquely identify a place in the Google Places database and on Google Maps. Learn more about Place IDs in the Places API developer guide.
        /// </summary>
        [Name("place_id")]
        public string PlaceId;

        /// <summary>
        /// An array of strings denoting the type of the returned geocoded element. For a list of possible strings, refer to the Address Component Types section of the Developer's Guide.
        /// </summary>
        public string[] Types;
    }
}