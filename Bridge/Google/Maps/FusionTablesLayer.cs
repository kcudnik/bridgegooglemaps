namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A FusionTablesLayer allows you to display data from a Google Fusion
    /// Table on a map, as a rendered layer. (See
    /// https://developers.google.com/fusiontables/ for more information about
    /// Fusion Tables).
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class FusionTablesLayer : MVCObject
    {
        /// <summary>
        /// A layer that displays data from a Fusion Table.
        /// </summary>
        /// <param name="options">Options parameter.</param>
        public extern FusionTablesLayer(FusionTablesLayerOptions options);

        /// <summary>
        /// Returns the map on which this layer is displayed.
        /// </summary>
        /// <returns>
        /// The <see cref="Map"/>.
        /// </returns>
        public extern Map GetMap();

        /// <summary>
        /// Renders the layer on the specified map. If map is set to null, the
        /// layer will be removed.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Map map);

        /// <summary>
        /// The set options.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public extern void SetOptions(FusionTablesLayerOptions options);
    }
}
