namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Contains details of the author of a KML document or feature.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class KmlAuthor
    {
        /// <summary>
        /// The author's e-mail address, or an empty string if not specified.
        /// </summary>
        public string Email;

        /// <summary>
        /// The author's name, or an empty string if not specified.
        /// </summary>
        public string Name;

        /// <summary>
        /// The author's home page, or an empty string if not specified.
        /// </summary>
        public string Url;
    }
}