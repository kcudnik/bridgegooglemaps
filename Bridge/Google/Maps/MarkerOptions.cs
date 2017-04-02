namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The marker options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MarkerOptions
    {
        /// <summary>
        /// The offset from the marker's position to the tip of an InfoWindow that has been opened with the marker as anchor.
        /// </summary>
        public Point AnchorPoint;

        /// <summary>
        /// Which animation to play when marker is added to a map.
        /// </summary>
        public Animation Animation;

        /// <summary>
        /// Contains all the information needed to identify your application as the source of a save. In this context, 'place' means a business, point of interest or geographic location. attribution must be specified with a place in order to enable a save.
        /// </summary>
        public Attribution Attribution;

        /// <summary>
        /// If true, the marker receives mouse and touch events. Default value is true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        /// If false, disables cross that appears beneath the marker when dragging. This option is true by default.
        /// </summary>
        public bool CrossOnDrag;

        /// <summary>
        /// Mouse cursor to show on hover
        /// </summary>
        public string Cursor;

        /// <summary>
        /// If true, the marker can be dragged. Default value is false.
        /// </summary>
        public bool Draggable;

        /// <summary>
        /// Icon for the foreground. If a string is provided, it is treated as though it were an Icon with the string as url.
        /// </summary>
        public Union<string, Icon, Symbol> Icon;

        /// <summary>
        /// Adds a label to the marker. The label can either be a string, or a MarkerLabel object. Only the first character of the string will be displayed.
        /// </summary>
        public Union<string, MarkerLabel> Label;

        /// <summary>
        /// Map on which to display Marker.
        /// </summary>
        public Union<Map, StreetViewPanorama> Map;

        /// <summary>
        /// The marker's opacity between 0.0 and 1.0.
        /// </summary>
        public double Opacity;

        /// <summary>
        /// Optimization renders many markers as a single static element. Optimized rendering is enabled by default. Disable optimized rendering for animated GIFs or PNGs, or when each marker must be rendered as a separate DOM element (advanced usage only).
        /// </summary>
        public bool Optimized;

        /// <summary>
        /// Place information, used to identify and describe the place associated with this Marker. In this context, 'place' means a business, point of interest or geographic location. To allow a user to save this place, open an info window anchored on this marker. The info window will contain information about the place and an option for the user to save it. Only one of position or place can be specified.
        /// </summary>
        public MarkerPlace Place;

        /// <summary>
        /// Marker position. Required.
        /// </summary>
        public LatLng Position;

        /// <summary>
        /// Image map region definition used for drag/click.
        /// </summary>
        public MarkerShape Shape;

        /// <summary>
        /// Rollover text.
        /// </summary>
        public string Title;

        /// <summary>
        /// If true, the marker is visible.
        /// </summary>
        public bool Visible;

        /// <summary>
        /// All markers are displayed on the map in order of their zIndex, with higher values displaying in front of markers with lower values. By default, markers are displayed according to their vertical position on screen, with lower markers appearing in front of markers further up the screen.
        /// </summary>
        public int ZIndex;
    }
}