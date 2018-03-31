namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;
    using System;

    /// <summary>
    /// Displays the panorama for a given LatLng or panorama ID. A
    /// StreetViewPanorama object provides a Street View "viewer" which can be
    /// stand-alone within a separate &lt;div&gt; or bound to a Map.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StreetViewPanorama : MVCObject
    {
        /// <summary>
        /// Additional controls to attach to the panorama. To add a control to
        /// the panorama, add the control's &lt;div&gt; to the MVCArray
        /// corresponding to the ControlPosition where it should be rendered.
        /// </summary>
        public MVCArray<Node>[] Controls;

        /// <summary>
        /// Creates a panorama with the passed StreetViewPanoramaOptions.
        /// </summary>
        /// <param name="containter">The container.</param>
        /// <param name="opts">The options.</param>
        public extern StreetViewPanorama(Element containter, StreetViewPanoramaOptions opts = null);

        /// <summary>
        /// Returns the set of navigation links for the Street View panorama.
        /// </summary>
        /// <returns>
        /// The <see cref="StreetViewLink"/>.
        /// </returns>
        public extern StreetViewLink[] GetLinks();

        /// <summary>
        /// Returns the StreetViewLocation of the current panorama.
        /// </summary>
        /// <returns>
        /// The <see cref="StreetViewLocation"/>.
        /// </returns>
        public extern StreetViewLocation GetLocation();

        /// <summary>
        /// Returns the state of motion tracker. If true when the user
        /// physically moves the device and the browser supports it, the Street
        /// View Panorama tracks the physical movements.
        /// </summary>
        /// <returns><c>true</c>, if motion tracking was gotten, <c>false</c> otherwise.</returns>
        public extern bool GetMotionTracking();

        /// <summary>
        /// Returns the current panorama ID for the Street View panorama. This
        /// id is stable within the browser's current session only.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public extern string GetPano();

        /// <summary>
        /// Returns the heading and pitch of the photographer when this
        /// panorama was taken. For Street View panoramas on the road, this
        /// also reveals in which direction the car was travelling. This data
        /// is available after the pano_changed event.
        /// </summary>
        /// <returns>
        /// The <see cref="StreetViewPov"/>.
        /// </returns>
        public extern StreetViewPov GetPhotographPov();

        /// <summary>
        /// Returns the current LatLng position for the Street View panorama.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng GetPosition();

        /// <summary>
        /// Returns the current point of view for the Street View panorama.
        /// </summary>
        /// <returns>
        /// The <see cref="StreetViewPov"/>.
        /// </returns>
        public extern StreetViewPov GetPov();

        /// <summary>
        /// Returns the status of the panorama on completion of the
        /// setPosition() or setPano() request.
        /// </summary>
        /// <returns>
        /// The <see cref="StreetViewStatus"/>.
        /// </returns>
        public extern StreetViewStatus GetStatus();

        /// <summary>
        /// Returns true if the panorama is visible. It does not specify
        /// whether Street View imagery is available at the specified position.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        /// Returns the zoom level of the panorama. Fully zoomed-out is level
        /// 0, where the field of view is 180 degrees. Zooming in increases the
        /// zoom level.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public extern int GetZoom();

        /// <summary>
        /// Set the custom panorama provider called on pano change to load
        /// custom panoramas.
        /// </summary>
        /// <param name="provider">
        /// The provider.
        /// </param>
        /// <param name="opt_options">
        /// The optional options.
        /// </param>
        public extern void RegisterPanoProvider(Func<string, StreetViewPanoramaData> provider, PanoProviderOptions opt_options = null);

        /// <summary>
        /// Sets the set of navigation links for the Street View panorama.
        /// </summary>
        /// <param name="links">
        /// The links.
        /// </param>
        public extern void SetLinks(StreetViewLink[] links);

        /// <summary>
        /// Sets the state of motion tracker. If true when the user physically
        /// moves the device and the browser supports it, the Street View
        /// Panorama tracks the physical movements.
        /// </summary>
        /// <param name="motionTracking">If set to <c>true</c> motion tracking.</param>
        public extern void SetMotionTracking(bool motionTracking);

        /// <summary>
        /// Sets a collection of key-value pairs.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public extern void SetOptions(StreetViewPanoramaOptions options);

        /// <summary>
        /// Sets the current panorama ID for the Street View panorama.
        /// </summary>
        /// <param name="pano">
        /// The pano.
        /// </param>
        public extern void SetPano(string pano);

        /// <summary>
        /// Sets the current LatLng position for the Street View panorama.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        public extern void SetPosition(Union<LatLngLiteral, LatLng> latLng);

        /// <summary>
        /// Sets the point of view for the Street View panorama.
        /// </summary>
        /// <param name="pov">
        /// The pov.
        /// </param>
        public extern void SetPov(StreetViewPov pov);

        /// <summary>
        /// Sets to true to make the panorama visible. If set to false, the
        /// panorama will be hidden whether it is embedded in the map or in its
        /// own &lt;div&gt;.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetVisible(bool flag);

        /// <summary>
        /// Sets the zoom level of the panorama. Fully zoomed-out is level 0,
        /// where the field of view is 180 degrees. Zooming in increases the
        /// zoom level.
        /// </summary>
        /// <param name="zoom">
        /// The zoom.
        /// </param>
        public extern void SetZoom(int zoom);
    }
}
