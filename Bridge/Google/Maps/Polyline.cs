namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A polyline is a linear overlay of connected line segments on the map.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Polyline : MVCObject
    {
        /// <summary>
        ///     Create a polyline using the passed PolylineOptions, which specify
        ///     both the path of the polyline and the stroke style to use when
        ///     drawing the polyline. You may pass either an array of LatLngs or an
        ///     MVCArray of LatLngs when constructing a polyline, though simple
        ///     arrays are converted to MVCArrays within the polyline upon
        ///     instantiation.
        /// </summary>
        /// <param name="opts">The options.</param>
        public extern Polyline(PolylineOptions opts = null);

        /// <summary>
        ///     Returns whether this shape can be dragged by the user.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetDraggable();

        /// <summary>
        ///     Returns whether this shape can be edited by the user.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetEditable();

        /// <summary>
        ///     Returns the map on which this shape is attached.
        /// </summary>
        /// <returns>
        ///     The <see cref="Map" />.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        ///     Retrieves the path.
        /// </summary>
        /// <returns>
        ///     The path.
        /// </returns>
        public extern MVCArray<LatLng> GetPath();

        /// <summary>
        ///     Returns whether this poly is visible on the map.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        ///     If set to true, the user can drag this shape over the map. The
        ///     geodesic property defines the mode of dragging.
        /// </summary>
        /// <param name="flag">
        ///     The flag.
        /// </param>
        public extern void SetDraggable(bool flag);

        /// <summary>
        ///     If set to true, the user can edit this shape by dragging the
        ///     control points shown at the vertices and on each segment.
        /// </summary>
        /// <param name="flag">
        ///     The flag.
        /// </param>
        public extern void SetEditable(bool flag);

        /// <summary>
        ///     Renders this shape on the specified map. If map is set to null, the
        ///     shape will be removed.
        /// </summary>
        /// <param name="map">
        ///     The map.
        /// </param>
        public extern void SetMap(Map map);

        /// <summary>
        ///     The set options.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        public extern void SetOptions(PolylineOptions options);

        /// <summary>
        ///     Sets the path. See PolylineOptions for more details.
        /// </summary>
        /// <param name="path">
        ///     The path.
        /// </param>
        public extern void SetPath(Union<LatLngLiteral[], LatLng[], MVCArray<LatLng>> path);

        /// <summary>
        ///     Hides this poly if set to false.
        /// </summary>
        /// <param name="visible">
        ///     The visible.
        /// </param>
        public extern void SetVisible(bool visible);
    }
}