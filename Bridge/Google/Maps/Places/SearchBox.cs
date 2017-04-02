namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Google.Maps;
    using Bridge.Html5;

    /// <summary>
    /// A service to provide query predictions based on a user's text input. It attaches to an input element of type text, and listens for text entry in that field. The list of predictions is presented as a drop-down list, and is updated as text is entered
    /// </summary>
    [External]
    [Namespace("google.maps.places")]
    public class SearchBox : MVCObject
    {
        /// <summary>
        /// Creates a new instance of SearchBox that attaches to the specified input text field with the given options.
        /// </summary>
        /// <param name="inputField">the Input element.</param>
        /// <param name="opts">The options.</param>
        public extern SearchBox(HTMLInputElement inputField, SearchBoxOptions opts = null);

        /// <summary>
        /// Returns the bounds to which query predictions are biased.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLngBounds"/>.
        /// </returns>
        public extern LatLngBounds GetBounds();

        /// <summary>
        /// Returns the query selected by the user, or null if no places have been found yet, to be used with places_changed event.
        /// </summary>
        /// <returns>
        /// The <see cref="PlaceResult"/>.
        /// </returns>
        public extern PlaceResult[] GetPlaces();

        /// <summary>
        /// Sets the region to use for biasing query predictions. Results will only be biased towards this area and not be completely restricted to it.
        /// </summary>
        /// <param name="bounds">
        /// The bounds.
        /// </param>
        public extern void SetBounds(Union<LatLngBounds, LatLngBoundsLiteral> bounds);
    }
}
