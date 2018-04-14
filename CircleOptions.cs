namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The circle options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class CircleOptions
    {
        /// <summary>
        ///     The center.
        /// </summary>
        public LatLng Center;

        /// <summary>
        ///     Indicates whether this Circle handles mouse events. Defaults to
        ///     true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        ///     If set to true, the user can drag this circle over the map.
        ///     Defaults to false.
        /// </summary>
        public bool Draggable;

        /// <summary>
        ///     If set to true, the user can edit this circle by dragging the
        ///     control points shown at the center and around the circumference of
        ///     the circle. Defaults to false.
        /// </summary>
        public bool Editable;

        /// <summary>
        ///     The fill color. All CSS3 colors are supported except for extended
        ///     named colors.
        /// </summary>
        public string FillColor;

        /// <summary>
        ///     The fill opacity between 0.0 and 1.0
        /// </summary>
        public double FillOpacity;

        /// <summary>
        ///     Map on which to display Circle.
        /// </summary>
        public Map Map;

        /// <summary>
        ///     The radius in meters on the Earth's surface
        /// </summary>
        public double Radius;

        /// <summary>
        ///     The stroke color. All CSS3 colors are supported except for extended
        ///     named colors.
        /// </summary>
        public string StrokeColor;

        /// <summary>
        ///     The stroke opacity between 0.0 and 1.0
        /// </summary>
        public double StrokeOpacity;

        /// <summary>
        ///     The stroke position. Defaults to CENTER. This property is not
        ///     supported on Internet Explorer 8 and earlier.
        /// </summary>
        public StrokePosition StrokePosition;

        /// <summary>
        ///     The stroke width in pixels.
        /// </summary>
        public double StrokeWeight;

        /// <summary>
        ///     Whether this circle is visible on the map. Defaults to true.
        /// </summary>
        public bool Visible;

        /// <summary>
        ///     The z index.
        /// </summary>
        public int ZIndex;
    }
}