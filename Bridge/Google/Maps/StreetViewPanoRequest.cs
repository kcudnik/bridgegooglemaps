
namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A StreetViewPanoRequest is used with the getPanorama to find a panorama
    /// with a specified ID.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewPanoRequest
    {
        /// <summary>
        /// Specifies the pano ID to search for.
        /// </summary>
        public string Pano;
    }
}
