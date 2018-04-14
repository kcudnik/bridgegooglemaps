namespace Bridge.Google.Maps.Places
{
    /// <summary>
    ///     Represents a single review of a place.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PlaceReview
    {
        /// <summary>
        ///     The aspects rated by the review. The ratings on a scale of 0 to 3.
        /// </summary>
        public PlaceAspectRating[] Aspects;

        /// <summary>
        ///     The name of the reviewer.
        /// </summary>
        [Name("author_name")]
        public string AuthorName;

        /// <summary>
        ///     A link to the reviewer's profile. This will be undefined when the
        ///     reviewer's profile is unavailable.
        /// </summary>
        [Name("author_url")]
        public string AuthorUrl;

        /// <summary>
        ///     An IETF language code indicating the language in which this review
        ///     is written. Note that this code includes only the main language tag
        ///     without any secondary tag indicating country or region. For
        ///     example, all the English reviews are tagged as 'en' rather than
        ///     'en-AU' or 'en-UK'.
        /// </summary>
        public string Language;

        /// <summary>
        ///     The text of a review.
        /// </summary>
        public string Text;
    }
}