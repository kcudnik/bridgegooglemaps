namespace Bridge.Google.Maps.Places
{
    using Bridge;

    /// <summary>
    /// The get url delegate.
    /// </summary>
    /// <param name="opts">
    /// The opts.
    /// </param>
    /// <returns>
    /// The photo url.
    /// </returns>
    public delegate string GetUrlDelegate(PhotoOptions opts);

    /// <summary>
    /// Represents a photo element of a Place.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PlacePhoto
    {
        // TODO could be method
        /// <summary>
        /// Returns the image URL corresponding to the specified options. You
        /// must include a PhotoOptions object with at least one of maxWidth or
        /// maxHeight specified.
        /// </summary>
        public GetUrlDelegate GetUrl;

        /// <summary>
        /// The height of the photo in pixels.
        /// </summary>
        public int Height;

        /// <summary>
        /// Attribution text to be displayed for this photo.
        /// </summary>
        [Name("html_attributions")]
        public string[] HtmlAttributions;

        /// <summary>
        /// The width of the photo in pixels.
        /// </summary>
        public int Width;
    }
}
