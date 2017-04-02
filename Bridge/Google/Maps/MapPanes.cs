namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    /// <summary>
    /// This object contains the DOM elements in which overlays are rendered. They are listed below with 'Pane 0' at the bottom and 'Pane 4' at the top.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MapPanes
    {
        /// <summary>
        /// This pane contains the info window. It is above all map overlays. (Pane 4).
        /// </summary>
        public Element FloatPane;

        /// <summary>
        /// This pane is the lowest pane and is above the tiles. It may not receive DOM events. (Pane 0).
        /// </summary>
        public Element MapPane;

        /// <summary>
        /// This pane contains markers. It may not receive DOM events. (Pane 2).
        /// </summary>
        public Element MarkerLayer;

        /// <summary>
        /// This pane contains polylines, polygons, ground overlays and tile layer overlays. It may not receive DOM events. (Pane 1).
        /// </summary>
        public Element OverlayLayer;

        /// <summary>
        /// This pane contains elements that receive DOM events. (Pane 3).
        /// </summary>
        public Element OverlayMouseTarget;
    }
}