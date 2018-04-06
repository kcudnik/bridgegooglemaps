namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// This object defines the properties that can be set on a
    /// FusionTablesLayer object.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesLayerOptions
    {
        /// <summary>
        /// If true, the layer receives mouse events. Default value is true.
        /// </summary>
        public bool Clickable;

        /// <summary>
        /// Options which define the appearance of the layer as a heatmap.
        /// </summary>
        public FusionTablesHeatmap Heatmap;

        /// <summary>
        /// The map on which to display the layer.
        /// </summary>
        public Map Map;

        /// <summary>
        /// Options defining the data to display.
        /// </summary>
        public FusionTablesQuery Query;

        /// <summary>
        /// An array of up to 5 style specifications, which control the
        /// appearance of features within the layer.
        /// </summary>
        public FusionTablesStyle[] Styles;

        /// <summary>
        /// Suppress the rendering of info windows when layer features are
        /// clicked.
        /// </summary>
        public bool SuppressInfoWindows;
    }
}
