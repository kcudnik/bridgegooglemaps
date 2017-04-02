namespace Bridge.Google.Maps.Places
{
    using Bridge;

    /// <summary>
    /// Defines information about a Place.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PlaceResult
    {
        /// <summary>
        /// The collection of address components for this Place's location.
        /// </summary>
        [Name("address_components")]
        public GeocoderAddressComponent[] AddressComponents;

        /// <summary>
        /// The rated aspects of this Place, based on Google and Zagat user reviews. The ratings are on a scale of 0 to 30.
        /// </summary>
        public PlaceAspectRating[] Aspects;

        /// <summary>
        /// The Place's full address.
        /// </summary>
        [Name("formatted_address")]
        public string FormattedAddress;

        /// <summary>
        /// The Place's phone number, formatted according to the number's regional convention.
        /// </summary>
        [Name("formatted_phone_number")]
        public string FormattedPhoneNumber;

        /// <summary>
        /// The Place's geometry-related information.
        /// </summary>
        public PlaceGeometry Geometry;

        /// <summary>
        /// Attribution text to be displayed for this Place result.
        /// </summary>
        [Name("html_attributions")]
        public string[] HtmlAttributions;

        /// <summary>
        /// URL to an image resource that can be used to represent this Place's category.
        /// </summary>
        public string Icon;

        /// <summary>
        /// The Place's phone number in international format. International format includes the country code, and is prefixed with the plus (+) sign.
        /// </summary>
        [Name("International_phone_number")]
        public string InternationalPhoneNumber;

        /// <summary>
        /// The Place's name. Note: In the case of user entered Places, this is the raw text, as typed by the user. Please exercise caution when using this data, as malicious users may try to use it as a vector for code injection attacks (See http://en.wikipedia.org/wiki/Code_injection).
        /// </summary>
        public string Name;

        /// <summary>
        /// A flag indicating whether the Place is permanently closed. If the place is not permanently closed, the flag is not present in search or details responses.
        /// </summary>
        [Name("permamently_closed")]
        public bool PermamentlyClosed;

        /// <summary>
        /// Photos of this Place. The collection will contain up to ten PlacePhoto objects.
        /// </summary>
        public PlacePhoto[] Photos;

        /// <summary>
        /// A unique identifier for a place.
        /// </summary>
        [Name("place_id")]
        public string Place_id;

        /// <summary>
        /// The price level of the Place, on a scale of 0 to 4. Price levels are interpreted as follows:
        /// 0: Free
        /// 1: Inexpensive
        /// 2: Moderate
        /// 3: Expensive
        /// 4: Very Expensive
        /// </summary>
        [Name("price_level")]
        public int PriceLevel;

        /// <summary>
        /// A rating, between 1.0 to 5.0, based on user reviews of this Place.
        /// </summary>
        public double Rating;

        /// <summary>
        /// A list of reviews of this Place.
        /// </summary>
        public PlaceReview[] Reviews;

        /// <summary>
        /// An array of types for this Place (e.g., ["political", "locality"] or ["restaurant", "establishment"]).
        /// </summary>
        public string[] Types;

        /// <summary>
        /// URL of the official Google page for this place. This is the Google-owned page that contains the best available information about the place.
        /// </summary>
        public string Url;

        /// <summary>
        /// The offset from UTC of the Place's current timezone, in minutes. For example, Sydney, Australia in daylight savings is 11 hours ahead of UTC, so the utc_offset will be 660. For timezones behind UTC, the offset is negative. For example, utc_offest is -60 for Cape Verde.
        /// </summary>
        [Name("utc_offset")]
        public double UtcOffset;

        /// <summary>
        /// A fragment of the Place's address for disambiguation (usually street name and locality).
        /// </summary>
        public string Vicinity;

        /// <summary>
        /// The authoritative website for this Place, such as a business' homepage.
        /// </summary>
        public string Website;
    }
}