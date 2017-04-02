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
        /// Selects the element type to which a styler should be applied. An
        /// element type distinguishes between the different representations of
        /// a feature. Optional; if elementType is not specified, the value is
        /// assumed to be 'all'.
        /// </summary>
        public MapTypeStyleElementType ElementType;

        /// <summary>
        /// Selects the feature, or group of features, to which a styler should
        /// be applied. Optional; if featureType is not specified, the value is
        /// assumed to be 'all'.
        /// </summary>
        public MapTypeStyleFeatureType FeatureType;

        /// <summary>
        /// The style rules to apply to the selectors. The rules are applied to
        /// the map's elements in the order they are listed in this array.
        /// </summary>
        public MapTypeStyler[] Stylers;
    }
}
