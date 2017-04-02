namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// You can implement this class if you want to display custom types of overlay objects on the map.
    /// Inherit from this class by setting your overlay's prototype: MyOverlay.prototype = new google.maps.OverlayView();. The OverlayView constructor is guaranteed to be an empty function.
    /// You must implement three methods: onAdd(), draw(), and onRemove().
    /// In the onAdd() method, you should create DOM objects and append them as children of the panes.
    /// In the draw() method, you should position these elements.
    /// In the onRemove() method, you should remove the objects from the DOM.
    /// You must call setMap() with a valid Map object to trigger the call to the onAdd() method and setMap(null) in order to trigger the onRemove() method.The setMap() method can be called at the time of construction or at any point afterward when the overlay should be re-shown after removing.The draw() method will then be called whenever a map property changes that could change the position of the element, such as zoom, center, or map type.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class OverlayView : MVCObject
    {
        /// <summary>
        /// Implement this method to draw or update the overlay. This method is called after onAdd() and when the position from projection.fromLatLngToPixel() would return a new value for a given LatLng. This can happen on change of zoom, center, or map type. It is not necessarily called on drag or resize.
        /// </summary>
        public extern virtual void Draw();

        /// <summary>
        /// The get map.
        /// </summary>
        /// <returns>
        /// The map.
        /// </returns>
        public extern Union<Map, StreetViewPanorama> GetMap();

        /// <summary>
        /// Returns the panes in which this OverlayView can be rendered. The panes are not initialized until onAdd is called by the API.
        /// </summary>
        /// <returns>
        /// The <see cref="MapPanes"/>.
        /// </returns>
        public extern MapPanes GetPanes();

        /// <summary>
        /// Returns the MapCanvasProjection object associated with this OverlayView. The projection is not initialized until onAdd is called by the API.
        /// </summary>
        /// <returns>
        /// The <see cref="MapCanvasProjection"/>.
        /// </returns>
        public extern MapCanvasProjection GetProjection();

        /// <summary>
        /// Implement this method to initialize the overlay DOM elements. This method is called once after setMap() is called with a valid map. At this point, panes and projection will have been initialized.
        /// </summary>
        public extern virtual void OnAdd();

        /// <summary>
        /// Implement this method to remove your elements from the DOM. This method is called once following a call to setMap(null).
        /// </summary>
        public extern virtual void OnRemove();

        /// <summary>
        /// Adds the overlay to the map or panorama.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Union<Map, StreetViewPanorama> map);
    }
}
