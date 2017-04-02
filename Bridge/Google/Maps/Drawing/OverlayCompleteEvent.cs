namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    /// <summary>
    /// The properties of an overlaycomplete event on a DrawingManager.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class OverlayCompleteEvent
    {
        /// <summary>
        /// The completed overlay.
        /// </summary>
        public Union<Marker, Polyline, Polygon, Circle, Rectangle> Overlay;

        /// <summary>
        /// The completed overlay's type.
        /// </summary>
        public OverlayType Type;
    }
}