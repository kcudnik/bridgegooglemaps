namespace Bridge.Google.Maps
{
    using Bridge;

    // NOTE no constructor, maps internal created

    /// <summary>
    /// This object is made available to the OverlayView from within the draw
    /// method. It is not guaranteed to be initialized until draw is called.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class MapCanvasProjection : MVCObject
    {
        /// <summary>
        /// Computes the geographical coordinates from pixel coordinates in the
        /// map's container.
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
        public extern LatLng FromContainerPixelToLatLng(Point pixel, bool nowrap = false);

        /// <summary>
        /// Computes the geographical coordinates from pixel coordinates in the
        /// div that holds the draggable map.
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
        public extern LatLng FromDivPixelToLatLng(Point pixel, bool nowrap = false);

        /// <summary>
        /// Computes the pixel coordinates of the given geographical location
        /// in the map's container element.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public extern Point FromLatLngToContainerPixel(LatLng latLng);

        /// <summary>
        /// Computes the pixel coordinates of the given geographical location
        /// in the DOM element that holds the draggable map.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        /// <returns>
        /// The <see cref="Point"/>.
        /// </returns>
        public extern Point FromLatLngToDivPixel(LatLng latLng);

        /// <summary>
        /// The width of the world in pixels in the current zoom level. For
        /// projections with a heading angle of either 90 or 270 degrees, this
        /// corresponds to the pixel span in the Y-axis.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public extern double GetWorldWidth();
    }
}
