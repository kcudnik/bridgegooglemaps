namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A layer that illustrates the locations where Street View is available.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StreetViewCoverageLayer : MVCObject
    {
        /// <summary>
        /// Returns the map on which this layer is displayed.
        /// </summary>
        /// <returns>
        /// The <see cref="Map"/>.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        /// Renders the layer on the specified map. If the map is set to null, the layer will be removed.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Map map);
    }
}