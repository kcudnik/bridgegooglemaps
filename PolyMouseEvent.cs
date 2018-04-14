namespace Bridge.Google.Maps
{
    /// <summary>
    ///     This object is returned from mouse events on polylines and polygons.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class PolyMouseEvent : MouseEvent
    {
        /// <summary>
        ///     The index of the edge within the path beneath the cursor when the
        ///     event occurred, if the event occurred on a mid-point on an editable
        ///     polygon.
        /// </summary>
        public int Edge;

        /// <summary>
        ///     The index of the path beneath the cursor when the event occurred,
        ///     if the event occurred on a vertex and the polygon is editable.
        ///     Otherwise undefined.
        /// </summary>
        public int Path;

        /// <summary>
        ///     The index of the vertex beneath the cursor when the event occurred,
        ///     if the event occurred on a vertex and the polyline or polygon is
        ///     editable. If the event does not occur on a vertex, the value is
        ///     undefined.
        /// </summary>
        public int Vertex;
    }
}