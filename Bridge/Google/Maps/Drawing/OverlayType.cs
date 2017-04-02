namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    /// <summary>
    /// The types of overlay that may be created by the DrawingManager.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps.drawing")]
    public enum OverlayType
    {
        /// <summary>
        /// Specifies that the DrawingManager creates circles, and that the overlay given in the overlaycomplete event is a circle.
        /// </summary>
        [Name("CIRCLE")]
        Circle,

        /// <summary>
        /// Specifies that the DrawingManager creates markers, and that the overlay given in the overlaycomplete event is a marker.
        /// </summary>
        [Name("MARKER")]
        Marker,

        /// <summary>
        /// Specifies that the DrawingManager creates polygons, and that the overlay given in the overlaycomplete event is a polygon.
        /// </summary>
        [Name("POLYGON")]
        Polygon,

        /// <summary>
        /// Specifies that the DrawingManager creates polylines, and that the overlay given in the overlaycomplete event is a polyline.
        /// </summary>
        [Name("POLYLINE")]
        Polyline,

        /// <summary>
        /// Specifies that the DrawingManager creates rectangles, and that the overlay given in the overlaycomplete event is a rectangle.
        /// </summary>
        [Name("RECTANGLE")]
        Rectangle
    }
}