namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The polygon options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PolygonOptions
    {
        /// <summary>
        ///     Indicates whether this Polygon handles mouse events. Defaults to
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
        ///     The fill color. All CSS3 colors are supported except for extended
        ///     named colors.
        /// </summary>
        public string FillColor;

        /// <summary>
        ///     The fill opacity between 0.0 and 1.0
        /// </summary>
        public double FillOpacity;

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
        ///     Map on which to display Polygon.
        /// </summary>
        public Map Map;

        /// <summary>
        ///     The ordered sequence of coordinates that designates a closed loop.
        ///     Unlike polylines, a polygon may consist of one or more paths. As a
        ///     result, the paths property may specify one or more arrays of LatLng
        ///     coordinates. Paths are closed automatically; do not repeat the
        ///     first vertex of the path as the last vertex. Simple polygons may be
        ///     defined using a single array of LatLngs. More complex polygons may
        ///     specify an array of arrays. Any simple arrays are converted into
        ///     MVCArrays. Inserting or removing LatLngs from the MVCArray will
        ///     automatically update the polygon on the map.
        /// </summary>
        public Union<MVCArray<MVCArray<LatLng>>, MVCArray<LatLng>, LatLng[][], LatLngLiteral[][], LatLng[],
            LatLngLiteral[]> Paths;

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
        ///     Whether this polygon is visible on the map. Defaults to true.
        /// </summary>
        public bool Visible;

        /// <summary>
        ///     The zIndex compared to other polys.
        /// </summary>
        public int ZIndex;
    }
}