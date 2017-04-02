namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The marker place.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MarkerPlace
    {
        /// <summary>
        /// The LatLng of the entity described by this Place. This must be
        /// provided for the Place to be considered valid.
        /// </summary>
        public Union<LatLng, LatLngLiteral> Location;

        /// <summary>
        /// The place ID of the place (such as a business or point of
        /// interest). The place ID is a unique identifier of a place in the
        /// Google Maps database. Note that the placeId is the most accurate
        /// way of identifying a place. If possible, you should specify the
        /// placeId rather than a placeQuery. A place ID can be retrieved from
        /// any request to the Places API, such as a TextSearch. Place IDs can
        /// also be retrieved from requests to the Geocoding API.
        /// </summary>
        public string PlaceId;

        /// <summary>
        /// A search query describing the place (such as a business or point of
        /// interest). An example query would be "Quay, Upper Level, Overseas
        /// Passenger Terminal 5 Hickson Road, The Rocks NSW". If possible, you
        /// should specify the placeId rather than a placeQuery. The API does
        /// not guarantee the accuracy of resolving the query string to a
        /// place. If both the placeId and placeQuery are provided, an error is
        /// thrown.
        /// </summary>
        public string Query;
    }
}
