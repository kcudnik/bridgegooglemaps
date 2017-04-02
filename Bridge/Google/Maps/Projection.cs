namespace Bridge.Google.Maps
{
    /// <summary>
    /// The Projection interface.
    /// </summary>
    public interface Projection
    {
        /// <summary>
        /// Translates from the LatLng cylinder to the Point plane. This
        /// interface specifies a function which implements translation from
        /// given LatLng values to world coordinates on the map projection. The
        /// Maps API calls this method when it needs to plot locations on
        /// screen. Projection objects must implement this method.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        Point FromLatLngToPoint(LatLng latLng, Point point = null);

        /// <summary>
        /// This interface specifies a function which implements translation
        /// from world coordinates on a map projection to LatLng values. The
        /// Maps API calls this method when it needs to translate actions on
        /// screen to positions on the map. Projection objects must implement
        /// this method.
        /// </summary>
        /// <param name="pixel">
        /// The pixel.
        /// </param>
        /// <param name="nowrap">
        /// The nowrap.
        /// </param>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        LatLng FromPointToLatLng(Point pixel, bool nowrap = false);
    }
}
