namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A polygon (like a polyline) defines a series of connected coordinates
    /// in an ordered sequence. Additionally, polygons form a closed loop and
    /// define a filled region. See the samples in the developer's guide,
    /// starting with a simple polygon, a polygon with a hole, and more. Note
    /// that you can also use the Data layer to create a polygon. The Data
    /// layer offers a simpler way of creating holes because it handles the
    /// order of the inner and outer paths for you.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Polygon : MVCObject
    {
        /// <summary>
        /// Create a polygon using the passed PolygonOptions, which specify the
        /// polygon's path, the stroke style for the polygon's edges, and the
        /// fill style for the polygon's interior regions. A polygon may
        /// contain one or more paths, where each path consists of an array of
        /// LatLngs. You may pass either an array of LatLngs or an MVCArray of
        /// LatLngs when constructing these paths. Arrays are converted to
        /// MVCArrays within the polygon upon instantiation.
        /// </summary>
        /// <param name="opts">The options.</param>
        public extern Polygon(PolygonOptions opts = null);

        /// <summary>
        /// Returns whether this shape can be dragged by the user.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetDraggable();

        /// <summary>
        /// Returns whether this shape can be edited by the user.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetEditable();

        /// <summary>
        /// Returns the map on which this shape is attached.
        /// </summary>
        /// <returns>
        /// The <see cref="Map"/>.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        /// Retrieves the first path.
        /// </summary>
        /// <returns>
        /// The path.
        /// </returns>
        public extern MVCArray<LatLng> GetPath();

        /// <summary>
        /// Retrieves the paths for this polygon.
        /// </summary>
        /// <returns>
        /// The paths.
        /// </returns>
        public extern MVCArray<MVCArray<LatLng>> GetPaths();

        /// <summary>
        /// Returns whether this poly is visible on the map.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        /// If set to true, the user can drag this shape over the map. The
        /// geodesic property defines the mode of dragging.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetDraggable(bool flag);

        /// <summary>
        /// If set to true, the user can edit this shape by dragging the
        /// control points shown at the vertices and on each segment.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetEditable(bool flag);

        /// <summary>
        /// Renders this shape on the specified map. If map is set to null, the
        /// shape will be removed.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Map map);

        /// <summary>
        /// The set options.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public extern void SetOptions(PolygonOptions options);

        /// <summary>
        /// Sets the first path. See PolygonOptions for more details.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public extern void SetPath(Union<LatLngLiteral[], LatLng[], MVCArray<LatLng>> path);

        /// <summary>
        /// Sets the path for this polygon.
        /// </summary>
        /// <param name="path">
        /// The path.
        /// </param>
        public extern void SetPaths(
            Union<MVCArray<LatLng>, LatLng[], LatLngLiteral[], LatLng[][], LatLngLiteral[][], MVCArray<MVCArray<LatLng>>> path);

        /// <summary>
        /// Hides this poly if set to false.
        /// </summary>
        /// <param name="visible">
        /// The visible.
        /// </param>
        public extern void SetVisible(bool visible);
    }
}
