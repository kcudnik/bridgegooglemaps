namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A collection of references to adjacent Street View panos.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewLink
    {
        /// <summary>
        /// A localized string describing the link.
        /// </summary>
        public string Description;

        /// <summary>
        /// The heading of the link.
        /// </summary>
        public double Heading;

        /// <summary>
        /// A unique identifier for the panorama. This id is stable within a
        /// session but unstable across sessions.
        /// </summary>
        public string Pano;
    }
}
