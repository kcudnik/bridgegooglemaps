namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A rectangle overlay.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Rectangle : MVCObject
    {
        /// <summary>
        /// Create a rectangle using the passed RectangleOptions, which specify
        /// the bounds and style.
        /// </summary>
        /// <param name="opts">The options.</param>
        public extern Rectangle(RectangleOptions opts = null);

        /// <summary>
        /// Returns the bounds of this rectangle.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLngBounds"/>.
        /// </returns>
        public extern LatLngBounds GetBounds();

        /// <summary>
        /// Returns whether this rectangle can be dragged by the user.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetDraggable();

        /// <summary>
        /// Returns whether this rectangle can be edited by the user.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetEditable();

        /// <summary>
        /// Returns the map on which this rectangle is displayed.
        /// </summary>
        /// <returns>
        /// The <see cref="Map"/>.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        /// Returns whether this rectangle is visible on the map.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        /// Sets the bounds of this rectangle.
        /// </summary>
        /// <param name="bounds">
        /// The bounds.
        /// </param>
        public extern void SetBounds(Union<LatLngBounds, LatLngBoundsLiteral> bounds);

        /// <summary>
        /// If set to true, the user can drag this rectangle over the map.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetDraggable(bool flag);

        /// <summary>
        /// If set to true, the user can edit this rectangle by dragging the
        /// control points shown at the corners and on each edge.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetEditable(bool flag);

        /// <summary>
        /// Renders the rectangle on the specified map. If map is set to null,
        /// the rectangle will be removed.
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
        public extern void SetOptions(RectangleOptions options);

        /// <summary>
        /// Hides this rectangle if set to false.
        /// </summary>
        /// <param name="visible">
        /// The visible.
        /// </param>
        public extern void SetVisible(bool visible);
    }
}
