namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Google.Maps;

    /// <summary>
    /// Defines information about the geometry of a Place.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PlaceGeometry
    {
        /// <summary>
        /// The Place's position.
        /// </summary>
        public LatLng Location;

        /// <summary>
        /// The preferred viewport when displaying this Place on a map. This
        /// property will be null if the preferred viewport for the Place is
        /// not known.
        /// </summary>
        public LatLngBounds Viewport;
    }
}
