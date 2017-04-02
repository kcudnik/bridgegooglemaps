namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// This object is returned from various mouse events on the map and overlays, and contains all the fields shown below.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class MouseEvent
    {
        /// <summary>
        /// latitude/longitude that was below the cursor when the event occurred.
        /// </summary>
        public LatLng LatLng;

        /// <summary>
        /// The pixel. May not be defined.
        /// </summary>
        public Point Pixel;

        /// <summary>
        /// Prevents this event from propagating further.
        /// </summary>
        public extern void Stop();
    }
}
