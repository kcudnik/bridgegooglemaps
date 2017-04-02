namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A representation of a location in the Street View panorama.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewLocation
    {
        /// <summary>
        /// A localized string describing the location.
        /// </summary>
        public string Description;

        /// <summary>
        /// The latlng of the panorama.
        /// </summary>
        public LatLng LatLng;

        /// <summary>
        /// A unique identifier for the panorama. This is stable within a
        /// session but unstable across sessions.
        /// </summary>
        public string Pano;

        /// <summary>
        /// Short description of the location.
        /// </summary>
        public string ShortDescription;
    }
}
