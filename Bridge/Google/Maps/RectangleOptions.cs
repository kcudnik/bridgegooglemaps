namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The rectangle options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class RectangleOptions
    {
        /// <summary>
        /// The bounds.
        /// </summary>
        public Union<LatLngBounds, LatLngBoundsLiteral> Bounds;

        /// <summary>
        /// Indicates whether this Rectangle handles mouse events. Defaults to true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        /// If set to true, the user can drag this rectangle over the map. Defaults to false.
        /// </summary>
        public bool Draggable;

        /// <summary>
        /// If set to true, the user can edit this rectangle by dragging the control points shown at the corners and on each edge. Defaults to false.
        /// </summary>
        public bool Editable;

        /// <summary>
        /// The fill color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public string FillColor;

        /// <summary>
        /// The fill opacity between 0.0 and 1.0
        /// </summary>
        public double FillOpacity;

        /// <summary>
        /// Map on which to display Rectangle.
        /// </summary>
        public Map Map;

        /// <summary>
        /// The stroke color. All CSS3 colors are supported except for extended named colors.
        /// </summary>
        public string StrokeColor;

        /// <summary>
        /// The stroke opacity between 0.0 and 1.0
        /// </summary>
        public double StrokeOpacity;

        /// <summary>
        /// The stroke position. Defaults to CENTER. This property is not supported on Internet Explorer 8 and earlier.
        /// </summary>
        public StrokePosition StrokePosition;

        /// <summary>
        /// The stroke width in pixels.
        /// </summary>
        public double StrokeWeight;

        /// <summary>
        /// Whether this rectangle is visible on the map. Defaults to true.
        /// </summary>
        public bool Visible;

        /// <summary>
        /// The zIndex compared to other polys.
        /// </summary>
        public int ZIndex;
    }
}