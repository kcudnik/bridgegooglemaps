namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The map options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MapOptions
    {
        /// <summary>
        /// Color used for the background of the Map div. This color will be
        /// visible when tiles have not yet loaded as the user pans. This
        /// option can only be set when the map is initialized.
        /// </summary>
        public string BackgroundColor;

        /// <summary>
        /// The initial Map center. Required.
        /// </summary>
        public LatLng Center;

        /// <summary>
        /// When false, map icons are not clickable. A map icon represents a
        /// point of interest, also known as a POI. By default map icons are
        /// clickable.
        /// </summary>
        public bool ClickableIcons;

        /// <summary>
        /// Enables/disables all default UI. May be overridden individually.
        /// </summary>
        public bool DisableDefaultUI;

        /// <summary>
        /// Enables/disables zoom and center on double click. Enabled by
        /// default.
        /// </summary>
        public bool DisableDoubleClickZoom;

        /// <summary>
        /// If false, prevents the map from being dragged. Dragging is enabled
        /// by default.
        /// </summary>
        public bool Draggable;

        /// <summary>
        /// The name or url of the cursor to display when mousing over a
        /// draggable map. This property uses the css cursor attribute to
        /// change the icon. As with the css property, you must specify at
        /// least one fallback cursor that is not a URL. For example:
        /// draggableCursor: 'url(http://www.example.com/icon.png), auto;'.
        /// </summary>
        public string DraggableCursor;

        /// <summary>
        /// The name or url of the cursor to display when the map is being
        /// dragged. This property uses the css cursor attribute to change the
        /// icon. As with the css property, you must specify at least one
        /// fallback cursor that is not a URL. For example: draggingCursor:
        /// 'url(http://www.example.com/icon.png), auto;'.
        /// </summary>
        public string DraggingCursor;

        /// <summary>
        /// The enabled/disabled state of the Fullscreen control.
        /// </summary>
        public bool FullscreenControl;

        /// <summary>
        /// The display options for the Fullscreen control.
        /// </summary>
        public FullscreenControlOptions FullscreenControlOptions;

        /// <summary>
        /// The heading for aerial imagery in degrees measured clockwise from
        /// cardinal direction North. Headings are snapped to the nearest
        /// available angle for which imagery is available.
        /// </summary>
        public double Heading;

        /// <summary>
        /// If false, prevents the map from being controlled by the keyboard.
        /// Keyboard shortcuts are enabled by default.
        /// </summary>
        public bool KayboardShorcuts;

        /// <summary>
        /// True if Map Maker tiles should be used instead of regular tiles.
        /// </summary>
        public bool MapMarker;

        /// <summary>
        /// The initial enabled/disabled state of the Map type control.
        /// </summary>
        public bool MapTypeControl;

        /// <summary>
        /// The initial display options for the Map type control.
        /// </summary>
        public MapTypeControlOptions MapTypeControlOptions;

        /// <summary>
        /// The initial Map mapTypeId. Defaults to ROADMAP.
        /// </summary>
        public MapTypeId MapTypeId;

        /// <summary>
        /// The maximum zoom level which will be displayed on the map. If
        /// omitted, or set to null, the maximum zoom from the current map type
        /// is used instead.
        /// </summary>
        public int MaxZoom;

        /// <summary>
        /// The minimum zoom level which will be displayed on the map. If
        /// omitted, or set to null, the minimum zoom from the current map type
        /// is used instead.
        /// </summary>
        public int MinZoom;

        /// <summary>
        /// If true, do not clear the contents of the Map div.
        /// </summary>
        public bool NoClear;

        /// <summary>
        /// The enabled/disabled state of the Overview Map control.
        /// Note: The Overview Map control is not available in the new set of
        /// controls introduced in v3.22 of the Google Maps JavaScript
        /// API.While using v3.22 and v3.23, you can choose to use the earlier
        /// set of controls rather than the new controls, thus making the
        /// Overview Map control available as part of the old control set.See
        /// What's New in the v3.22 Map Controls.
        /// </summary>
        public bool OverviewMapControl;

        /// <summary>
        /// The display options for the Overview Map control.
        /// Note: The Overview Map control is not available in the new set of
        /// controls introduced in v3.22 of the Google Maps JavaScript
        /// API.While using v3.22 and v3.23, you can choose to use the earlier
        /// set of controls rather than the new controls, thus making the
        /// Overview Map control available as part of the old control set.See
        /// What's New in the v3.22 Map Controls.
        /// </summary>
        public OverviewMapControlOptions OverviewMapControlOptions;

        /// <summary>
        /// The enabled/disabled state of the Pan control.
        /// Note: The Pan control is not available in the new set of controls
        /// introduced in v3.22 of the Google Maps JavaScript API.While using
        /// v3.22 and v3.23, you can choose to use the earlier set of controls
        /// rather than the new controls, thus making the Pan control available
        /// as part of the old control set.See What's New in the v3.22 Map
        /// Controls.
        /// </summary>
        public bool PanControl;

        /// <summary>
        /// The display options for the Pan control.
        /// Note: The Pan control is not available in the new set of controls
        /// introduced in v3.22 of the Google Maps JavaScript API.While using
        /// v3.22 and v3.23, you can choose to use the earlier set of controls
        /// rather than the new controls, thus making the Pan control available
        /// as part of the old control set.See What's New in the v3.22 Map
        /// Controls.
        /// </summary>
        public PanControlOptions PanControlOptions;

        /// <summary>
        /// The enabled/disabled state of the Rotate control.
        /// </summary>
        public bool RotateControl;

        /// <summary>
        /// The display options for the Rotate control.
        /// </summary>
        public RotateControlOptions RotateControlOptions;

        /// <summary>
        /// The initial enabled/disabled state of the Scale control.
        /// </summary>
        public bool ScaleControl;

        /// <summary>
        /// The initial display options for the Scale control.
        /// </summary>
        public ScaleControlOptions ScaleControlOptions;

        /// <summary>
        /// If false, disables scrollwheel zooming on the map. The scrollwheel
        /// is enabled by default.
        /// </summary>
        public bool Scrollwheel;

        /// <summary>
        /// The enabled/disabled state of the sign in control. This option only
        /// applies if signed_in=true has been passed as a URL parameter in the
        /// bootstrap request. You may want to use this option to hide the
        /// map's sign in control if you have provided another way for your
        /// users to sign in, such as the Google Sign-In button. This option
        /// does not affect the visibility of the Google avatar shown when the
        /// user is already signed in.
        /// </summary>
        public bool SignInControl;

        /// <summary>
        /// A StreetViewPanorama to display when the Street View pegman is
        /// dropped on the map. If no panorama is specified, a default
        /// StreetViewPanorama will be displayed in the map's div when the
        /// pegman is dropped.
        /// </summary>
        public StreetViewPanorama StreetView;

        /// <summary>
        /// The initial enabled/disabled state of the Street View Pegman
        /// control. This control is part of the default UI, and should be set
        /// to false when displaying a map type on which the Street View road
        /// overlay should not appear (e.g. a non-Earth map type).
        /// </summary>
        public bool StreetViewControl;

        /// <summary>
        /// The initial display options for the Street View Pegman control.
        /// </summary>
        public StreetViewControlOptions StreetViewControlOptions;

        /// <summary>
        /// Styles to apply to each of the default map types. Note that for
        /// Satellite/Hybrid and Terrain modes, these styles will only apply to
        /// labels and geometry.
        /// </summary>
        public MapTypeStyle[] Styles;

        /// <summary>
        /// Controls the automatic switching behavior for the angle of
        /// incidence of the map. The only allowed values are 0 and 45. The
        /// value 0 causes the map to always use a 0 overhead view regardless
        /// of the zoom level and viewport. The value 45 causes the tilt angle
        /// to automatically switch to 45 whenever 45 imagery is available for
        /// the current zoom level and viewport, and switch back to 0 whenever
        /// 45 imagery is not available (this is the default behavior). 45
        /// imagery is only available for SATELLITE and HYBRID map types,
        /// within some locations, and at some zoom levels. Note: getTilt
        /// returns the current tilt angle, not the value specified by this
        /// option. Because getTilt and this option refer to different things,
        /// do not bind() the tilt property; doing so may yield unpredictable
        /// effects.
        /// </summary>
        public double Tilt;

        /// <summary>
        /// The initial Map zoom level. Required.
        /// </summary>
        public int Zoom;

        /// <summary>
        /// The enabled/disabled state of the Zoom control.
        /// </summary>
        public bool ZoomControl;

        /// <summary>
        /// The display options for the Zoom control.
        /// </summary>
        public ZoomControlOptions ZoomControlOptions;
    }
}
