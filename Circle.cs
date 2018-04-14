namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A circle on the Earth's surface; also known as a "spherical cap".
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Circle : MVCObject
    {
        /// <summary>
        ///     Create a circle using the passed CircleOptions, which specify the
        ///     center, radius, and style.
        /// </summary>
        /// <param name="opts">
        ///     CircleOptions, which specify the center, radius, and style.
        /// </param>
        public extern Circle(CircleOptions opts = null);

        /// <summary>
        ///     Gets the LatLngBounds of this Circle.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLngBounds" />.
        /// </returns>
        public extern LatLngBounds GetBounds();

        /// <summary>
        ///     Returns the center of this circle.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public extern LatLng GetCenter();

        /// <summary>
        ///     Returns whether this circle can be dragged by the user.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetDraggable();

        /// <summary>
        ///     Returns whether this circle can be edited by the user.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetEditable();

        /// <summary>
        ///     Returns the map on which this circle is displayed.
        /// </summary>
        /// <returns>
        ///     The <see cref="Map" />.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        ///     Returns the radius of this circle (in meters).
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public extern double GetRadius();

        /// <summary>
        ///     Returns whether this circle is visible on the map.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        ///     Sets the center of this circle.
        /// </summary>
        /// <param name="center">
        ///     The center.
        /// </param>
        public extern void SetCenter(Union<LatLngLiteral, LatLng> center);

        /// <summary>
        ///     If set to true, the user can drag this circle over the map.
        /// </summary>
        /// <param name="draggable">
        ///     The draggable.
        /// </param>
        public extern void SetDraggable(bool draggable);

        /// <summary>
        ///     If set to true, the user can edit this circle by dragging the
        ///     control points shown at the center and around the circumference of
        ///     the circle.
        /// </summary>
        /// <param name="editable">
        ///     The editable.
        /// </param>
        public extern void SetEditable(bool editable);

        /// <summary>
        ///     Renders the circle on the specified map. If map is set to null, the
        ///     circle will be removed.
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
        public extern void SetOptions(CircleOptions options);

        /// <summary>
        ///     Sets the radius of this circle (in meters).
        /// </summary>
        /// <param name="radius">
        ///     The radius.
        /// </param>
        public extern void SetRadius(double radius);

        /// <summary>
        ///     Hides this circle if set to false.
        /// </summary>
        /// <param name="visible">
        ///     The visible.
        /// </param>
        public extern void SetVisible(bool visible);
    }
}