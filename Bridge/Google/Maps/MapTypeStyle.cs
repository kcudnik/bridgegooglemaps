namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The MapTypeStyle is a collection of selectors and stylers that define
    /// how the map should be styled. Selectors specify what map elements
    /// should be affected and stylers specify how those elements should be
    /// modified.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MapTypeStyle
    {
        /// <summary>
        /// The element to which a styler should be applied. An element is a
        /// visual aspect of a feature on the map. Example: a label, an icon,
        /// the stroke or fill applied to the geometry, and more. Optional. If
        /// elementType is not specified, the value is assumed to be 'all'. For
        /// details of usage and allowed values, see the style reference.
        /// </summary>
        public string ElementType;

        /// <summary>
        /// The feature, or group of features, to which a styler should be
        /// applied. Optional. If featureType is not specified, the value is
        /// assumed to be 'all'. For details of usage and allowed values, see
        /// the style reference.
        /// </summary>
        public string FeatureType;

        /// <summary>
        /// The style rules to apply to the selected map features and elements.
        /// The rules are applied in the order that you specify in this array.
        /// For guidelines on usage and allowed values, see the style
        /// reference.
        /// </summary>
        public object[] Stylers;
    }
}
