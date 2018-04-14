namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The polyline options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PolylineOptions
    {
        /// <summary>
        ///     Indicates whether this Polyline handles mouse events. Defaults to
        ///     true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        ///     If set to true, the user can drag this shape over the map. The
        ///     geodesic property defines the mode of dragging. Defaults to false.
        /// </summary>
        public bool Draggable;

        /// <summary>
        ///     If set to true, the user can edit this shape by dragging the
        ///     control points shown at the vertices and on each segment. Defaults
        ///     to false.
        /// </summary>
        public bool Editable;

        /// <summary>
        ///     When true, edges of the polygon are interpreted as geodesic and
        ///     will follow the curvature of the Earth. When false, edges of the
        ///     polygon are rendered as straight lines in screen space. Note that
        ///     the shape of a geodesic polygon may appear to change when dragged,
        ///     as the dimensions are maintained relative to the surface of the
        ///     earth. Defaults to false.
        /// </summary>
        public bool Geodesic;

        /// <summary>
        ///     The icons to be rendered along the polyline.
        /// </summary>
        public IconSequence[] Icons;

        /// <summary>
        ///     Map on which to display Polyline.
        /// </summary>
        public Map Map;

        /// <summary>
        ///     The ordered sequence of coordinates of the Polyline. This path may
        ///     be specified using either a simple array of LatLngs, or an MVCArray
        ///     of LatLngs. Note that if you pass a simple array, it will be
        ///     converted to an MVCArray Inserting or removing LatLngs in the
        ///     MVCArray will automatically update the polyline on the map.
        /// </summary>
        public Union<MVCArray<LatLng>, LatLng[], LatLngLiteral[]> Path;

        /// <summary>
        ///     The stroke color. All CSS3 colors are supported except for extended
        ///     named colors.
        /// </summary>
        public string StrokeColor;

        /// <summary>
        ///     The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public double StrokeOpacity;

        /// <summary>
        ///     The stroke width in pixels.
        /// </summary>
        public double StrokeWeight;

        /// <summary>
        ///     Whether this polyline is visible on the map. Defaults to true.
        /// </summary>
        public bool Visible;

        /// <summary>
        ///     The zIndex compared to other polys.
        /// </summary>
        public int ZIndex;
    }
}