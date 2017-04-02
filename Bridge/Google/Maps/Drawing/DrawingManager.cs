namespace Bridge.Google.Maps.Drawing
{
    using Bridge;

    /// <summary>
    /// Allows users to draw markers, polygons, polylines, rectangles, and
    /// circles on the map. The DrawingManager's drawing mode defines the type
    /// of overlay that will be created by the user. Adds a control to the map,
    /// allowing the user to switch drawing mode.
    /// </summary>
    [External]
    [Namespace("google.maps.drawing")]
    public class DrawingManager : MVCObject
    {
        /// <summary>
        /// Creates a DrawingManager that allows users to draw overlays on the
        /// map, and switch between the type of overlay to be drawn with a
        /// drawing control.
        /// </summary>
        /// <param name="options">The options.</param>
        public extern DrawingManager(DrawingManagerOptions options = null);

        /// <summary>
        /// Returns the DrawingManager's drawing mode.
        /// </summary>
        /// <returns>
        /// The <see cref="OverlayType"/>.
        /// </returns>
        public extern OverlayType GetDrawingMode();

        /// <summary>
        /// Returns the Map to which the DrawingManager is attached, which is
        /// the Map on which the overlays created will be placed.
        /// </summary>
        /// <returns>
        /// The <see cref="Map"/>.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        /// Changes the DrawingManager's drawing mode, which defines the type
        /// of overlay to be added on the map. Accepted values are MARKER,
        /// POLYGON, POLYLINE, RECTANGLE, CIRCLE, or null. A drawing mode of
        /// null means that the user can interact with the map as normal, and
        /// clicks do not draw anything.
        /// </summary>
        /// <param name="drawingMode">
        /// The drawing mode.
        /// </param>
        public extern void SetDrawingMode(OverlayType? drawingMode);

        /// <summary>
        /// Attaches the DrawingManager object to the specified Map.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Map map);

        /// <summary>
        /// Sets the DrawingManager's options.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public extern void SetOptions(DrawingManagerOptions options);
    }
}
