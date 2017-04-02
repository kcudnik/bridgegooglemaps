namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the zoom control.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class ZoomControlOptions
    {
        /// <summary>
        /// Position id. Used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition Position;

        /// <summary>
        /// Style id. Used to select what style of zoom control to display.
        /// </summary>
        public ZoomControlStyle Style;
    }
}
