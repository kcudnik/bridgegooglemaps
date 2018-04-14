namespace Bridge.Google.Maps
{
    using Html5;

    /// <summary>
    ///     The map.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Map : MVCObject
    {
        /// <summary>
        ///     Additional controls to attach to the map. To add a control to the
        ///     map, add the control's &lt;div&gt; to the MVCArray corresponding to
        ///     the ControlPosition where it should be rendered.
        /// </summary>
        public MVCArray<Node>[] Controls;

        /// <summary>
        ///     An instance of Data, bound to the map. Add features to this Data
        ///     object to conveniently display them on this map.
        /// </summary>
        public Data Data;

        /// <summary>
        ///     A registry of MapType instances by string ID.
        /// </summary>
        public MapTypeRegistry MapTypes;

        /// <summary>
        ///     Additional map types to overlay.
        /// </summary>
        public MVCArray<MapType> OverlayMapTypes;

        /// <summary>
        ///     Creates a new map inside of the given HTML container, which is
        ///     typically a DIV element.
        /// </summary>
        /// <param name="mapDiv">Node for map.</param>
        /// <param name="opts">Map options.</param>
        public extern Map(Element mapDiv, MapOptions opts = null);

        /// <summary>
        ///     Note: When the map is set to display: none, the fitBounds function
        ///     reads the map's size as 0x0, and therefore does not do anything. To
        ///     change the viewport while the map is hidden, set the map to
        ///     visibility: hidden, thereby ensuring the map div has an actual
        ///     size.
        /// </summary>
        /// <param name="bounds">
        ///     The bounds.
        /// </param>
        /// <param name="padding">
        ///     The padding.
        /// </param>
        public extern void FitBounds(Union<LatLngBounds, LatLngBoundsLiteral> bounds, int? padding = null);

        /// <summary>
        ///     Returns the lat/lng bounds of the current viewport. If more than
        ///     one copy of the world is visible, the bounds range in longitude
        ///     from -180 to 180 degrees inclusive. If the map is not yet
        ///     initialized (i.e. the mapType is still null), or center and zoom
        ///     have not been set then the result is null or undefined.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLngBounds" />.
        /// </returns>
        public extern LatLngBounds GetBounds();

        /// <summary>
        ///     Returns the position displayed at the center of the map. Note that
        ///     this LatLng object is not wrapped. See LatLng for more information.
        /// </summary>
        /// <returns>
        ///     The <see cref="LatLng" />.
        /// </returns>
        public extern LatLng GetCenter();

        /// <summary>
        ///     Returns the clickability of the map icons. A map icon represents a
        ///     point of interest, also known as a POI. If the returned value is
        ///     true, then the icons are clickable on the map.
        /// </summary>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool GetClickableIcons();

        /// <summary>
        ///     The get div.
        /// </summary>
        /// <returns>
        ///     The <see cref="Node" />.
        /// </returns>
        public extern Element GetDiv();

        /// <summary>
        ///     Returns the compass heading of aerial imagery. The heading value is
        ///     measured in degrees (clockwise) from cardinal direction North.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public extern double GetHeading();

        /// <summary>
        ///     The get map type id.
        /// </summary>
        /// <returns>
        ///     The <see cref="MapTypeId" /> or string.
        /// </returns>
        public extern Union<string, MapTypeId> GetMapTypeId();

        /// <summary>
        ///     Returns the current Projection. If the map is not yet initialized
        ///     (i.e. the mapType is still null) then the result is null. Listen to
        ///     projection_changed and check its value to ensure it is not null.
        /// </summary>
        /// <returns>
        ///     The <see cref="Projection" />.
        /// </returns>
        public extern Projection GetProjection();

        /// <summary>
        ///     Returns the default StreetViewPanorama bound to the map, which may
        ///     be a default panorama embedded within the map, or the panorama set
        ///     using setStreetView(). Changes to the map's streetViewControl will
        ///     be reflected in the display of such a bound panorama.
        /// </summary>
        /// <returns>
        ///     The <see cref="StreetViewPanorama" />.
        /// </returns>
        public extern StreetViewPanorama GetStreetView();

        /// <summary>
        ///     Returns the current angle of incidence of the map, in degrees from
        ///     the viewport plane to the map plane. The result will be 0 for
        ///     imagery taken directly overhead or 45 for 45 imagery. 45 imagery is
        ///     only available for SATELLITE and HYBRID map types, within some
        ///     locations, and at some zoom levels. Note: This method does not
        ///     return the value set by setTilt. See setTilt for details.
        /// </summary>
        /// <returns>
        ///     The <see cref="double" />.
        /// </returns>
        public extern double GetTilt();

        /// <summary>
        ///     The get zoom.
        /// </summary>
        /// <returns>
        ///     The <see cref="int" />.
        /// </returns>
        public extern int GetZoom();

        /// <summary>
        ///     Changes the center of the map by the given distance in pixels. If
        ///     the distance is less than both the width and height of the map, the
        ///     transition will be smoothly animated. Note that the map coordinate
        ///     system increases from west to east (for x values) and north to
        ///     south (for y values).
        /// </summary>
        /// <param name="x">
        ///     The x.
        /// </param>
        /// <param name="y">
        ///     The y.
        /// </param>
        public extern void PanBy(double x, double y);

        /// <summary>
        ///     Changes the center of the map to the given LatLng. If the change is
        ///     less than both the width and height of the map, the transition will
        ///     be smoothly animated.
        /// </summary>
        /// <param name="latLng">
        ///     The lat lng.
        /// </param>
        public extern void PanTo(Union<LatLng, LatLngLiteral> latLng);

        /// <summary>
        ///     Pans the map by the minimum amount necessary to contain the given
        ///     LatLngBounds. It makes no guarantee where on the map the bounds
        ///     will be, except that as much of the bounds as possible will be
        ///     visible. The bounds will be positioned inside the area bounded by
        ///     the map type and navigation (pan, zoom, and Street View) controls,
        ///     if they are present on the map. If the bounds is larger than the
        ///     map, the map will be shifted to include the northwest corner of the
        ///     bounds. If the change in the map's position is less than both the
        ///     width and height of the map, the transition will be smoothly
        ///     animated.
        /// </summary>
        /// <param name="latLngBounds">
        ///     The lat lng bounds.
        /// </param>
        public extern void PanToBounds(Union<LatLngBounds, LatLngBoundsLiteral> latLngBounds);

        /// <summary>
        ///     The set center.
        /// </summary>
        /// <param name="latLng">
        ///     The lat lng.
        /// </param>
        public extern void SetCenter(Union<LatLng, LatLngLiteral> latLng);

        /// <summary>
        ///     Controls whether the map icons are clickable or not. A map icon
        ///     represents a point of interest, also known as a POI. To disable the
        ///     clickability of map icons, pass a value of false to this method.
        /// </summary>
        /// <param name="value">
        ///     The value.
        /// </param>
        public extern void SetClickableIcons(bool value);

        /// <summary>
        ///     Sets the compass heading for aerial imagery measured in degrees
        ///     from cardinal direction North.
        /// </summary>
        /// <param name="heading">
        ///     The heading.
        /// </param>
        public extern void SetHeading(double heading);

        /// <summary>
        ///     The set map type id.
        /// </summary>
        /// <param name="mapTypeId">
        ///     The map type id.
        /// </param>
        public extern void SetMapTypeId(Union<string, MapTypeId> mapTypeId);

        /// <summary>
        ///     The set options.
        /// </summary>
        /// <param name="options">
        ///     The options.
        /// </param>
        public extern void SetOptions(MapOptions options);

        /// <summary>
        ///     Binds a StreetViewPanorama to the map. This panorama overrides the
        ///     default StreetViewPanorama, allowing the map to bind to an external
        ///     panorama outside of the map. Setting the panorama to null binds the
        ///     default embedded panorama back to the map.
        /// </summary>
        /// <param name="panorama">
        ///     The panorama.
        /// </param>
        public extern void SetStreetView(StreetViewPanorama panorama);

        /// <summary>
        ///     Controls the automatic switching behavior for the angle of
        ///     incidence of the map. The only allowed values are 0 and 45.
        ///     setTilt(0) causes the map to always use a 0 overhead view
        ///     regardless of the zoom level and viewport. setTilt(45) causes the
        ///     tilt angle to automatically switch to 45 whenever 45 imagery is
        ///     available for the current zoom level and viewport, and switch back
        ///     to 0 whenever 45 imagery is not available (this is the default
        ///     behavior). 45 imagery is only available for SATELLITE and HYBRID
        ///     map types, within some locations, and at some zoom levels. Note:
        ///     getTilt returns the current tilt angle, not the value set by
        ///     setTilt. Because getTilt and setTilt refer to different things, do
        ///     not bind() the tilt property; doing so may yield unpredictable
        ///     effects.
        /// </summary>
        /// <param name="tilt">
        ///     The tilt.
        /// </param>
        public extern void SetTilt(double tilt);

        /// <summary>
        ///     The set zoom.
        /// </summary>
        /// <param name="zoom">
        ///     The zoom.
        /// </param>
        public extern void SetZoom(int zoom);
    }
}