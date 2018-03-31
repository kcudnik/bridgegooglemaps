namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options defining the properties of a StreetViewPanorama object.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewPanoramaOptions
    {
        /// <summary>
        /// The enabled/disabled state of the address control.
        /// </summary>
        public bool AddressControl;

        /// <summary>
        /// The display options for the address control.
        /// </summary>
        public StreetViewAddressControlOptions AddressControlOptions;

        /// <summary>
        /// The enabled/disabled state of click-to-go.
        /// </summary>
        public bool ClickToGo;

        /// <summary>
        /// Enables/disables all default UI. May be overridden individually.
        /// </summary>
        public bool DisableDefaultUI;

        /// <summary>
        /// Enables/disables zoom on double click. Disabled by default.
        /// </summary>
        public bool DisableDoubleClickZoom;

        /// <summary>
        /// If true, the close button is displayed. Disabled by default.
        /// </summary>
        public bool EnableCloseButton;

        /// <summary>
        /// The enabled/disabled state of the fullscreen control.
        /// </summary>
        public bool FullscreenControl;

        /// <summary>
        /// The display options for the fullscreen control.
        /// </summary>
        public FullscreenControlOptions FullscreenControlOptions;

        /// <summary>
        /// The enabled/disabled state of the imagery acquisition date control.
        /// Disabled by default.
        /// </summary>
        public bool ImageDateControl;

        /// <summary>
        /// The enabled/disabled state of the links control.
        /// </summary>
        public bool LinksControl;

        /// <summary>
        /// Whether motion tracking is on or off. Enabled by default when the
        /// motion tracking control is present, so that the POV (point of view)
        /// follows the orientation of the device. This is primarily applicable
        /// to mobile devices. If motionTracking is set to false while
        /// motionTrackingControl is enabled, the motion tracking control
        /// appears but tracking is off. The user can tap the motion tracking
        /// control to toggle this option.
        /// </summary>
        public bool MotionTracking;

        /// <summary>
        /// The enabled/disabled state of the motion tracking control. Enabled
        /// by default when the device has motion data, so that the control
        /// appears on the map. This is primarily applicable to mobile devices.
        /// </summary>
        public bool MotionTrackingControl;

        /// <summary>
        /// The display options for the motion tracking control.
        /// </summary>
        public MotionTrackingControlOptions MotionTrackingControlOptions;

        /// <summary>
        /// The enabled/disabled state of the pan control.
        /// </summary>
        public bool PanControl;

        /// <summary>
        /// The display options for the pan control.
        /// </summary>
        public PanControlOptions PanControlOptions;

        /// <summary>
        /// The panorama ID, which should be set when specifying a custom
        /// panorama.
        /// </summary>
        public string Pano;

        /// <summary>
        /// The LatLng position of the Street View panorama.
        /// </summary>
        public Union<LatLng, LatLngLiteral> Position;

        /// <summary>
        /// The camera orientation, specified as heading and pitch, for the
        /// panorama.
        /// </summary>
        public StreetViewPov Pov;

        /// <summary>
        /// If false, disables scrollwheel zooming in Street View. The
        /// scrollwheel is enabled by default.
        /// </summary>
        public bool Scrollwheel;

        /// <summary>
        /// The display of street names on the panorama. If this value is not
        /// specified, or is set to true, street names are displayed on the
        /// panorama. If set to false, street names are not displayed.
        /// </summary>
        public bool ShowRoadLabels;

        /// <summary>
        /// If true, the Street View panorama is visible on load.
        /// </summary>
        public bool Visible;

        /// <summary>
        /// The zoom of the panorama, specified as a number. A zoom of 0 gives
        /// a 180 degrees Field of View.
        /// </summary>
        public bool Zoom;

        /// <summary>
        /// The enabled/disabled state of the zoom control.
        /// </summary>
        public bool ZoomControl;

        /// <summary>
        /// The display options for the zoom control.
        /// </summary>
        public ZoomControlOptions ZoomControlOptions;
    }
}
