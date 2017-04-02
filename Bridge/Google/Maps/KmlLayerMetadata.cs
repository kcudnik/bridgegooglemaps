namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Metadata for a single KML layer, in JSON format.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class KmlLayerMetadata
    {
        /// <summary>
        /// The layer's &lt;atom:author&gt;, extracted from the layer markup.
        /// </summary>
        public KmlAuthor Author;

        /// <summary>
        /// The layer's &lt;description&gt;, extracted from the layer markup.
        /// </summary>
        public string Description;

        /// <summary>
        /// Whether the layer has any screen overlays.
        /// </summary>
        public bool HasScreenOverlays;

        /// <summary>
        /// The layer's &lt;name&gt;, extracted from the layer markup.
        /// </summary>
        public string Name;

        /// <summary>
        /// The layer's &lt;Snippet&gt;, extracted from the layer markup
        /// </summary>
        public string Snippet;
    }
}
