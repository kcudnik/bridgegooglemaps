namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// This object is sent in an event when a user clicks on an icon on the map. The place ID of this place is stored in the placeId member. To prevent the default info window from showing up, call the stop() method on this event to prevent it being propagated. Learn more about place IDs in the Places API developer guide.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class IconMouseEvent : MouseEvent
    {
        /// <summary>
        /// The place ID of the place that was clicked. This place ID can be used to query more information about the feature that was clicked.
        /// </summary>
        public string PlaceId;
    }
}
