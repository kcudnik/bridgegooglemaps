namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Each MapTypeStyleElementType distinguishes between the different representations of a feature.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeStyleElementType
    {
        /// <summary>
        /// Apply the rule to all elements of the specified feature.
        /// </summary>
        [Name("all")]
        All,

        /// <summary>
        /// Apply the rule to the feature's geometry.
        /// </summary>
        [Name("geometry")]
        Geometry,

        /// <summary>
        /// Apply the rule to the fill of the feature's geometry.
        /// </summary>
        [Name("geometry.fill")]
        GeometryFill,

        /// <summary>
        /// Apply the rule to the stroke of the feature's geometry.
        /// </summary>
        [Name("geometry.stroke")]
        GeometryStroke,

        /// <summary>
        /// Apply the rule to the feature's labels.
        /// </summary>
        [Name("labels")]
        Labels,

        /// <summary>
        /// Apply the rule to icons within the feature's labels.
        /// </summary>
        [Name("labels.icon")]
        LabelsIcon,

        /// <summary>
        /// Apply the rule to the text in the feature's label.
        /// </summary>
        [Name("labels.text")]
        LabelsText,

        /// <summary>
        /// Apply the rule to the fill of the text in the feature's labels.
        /// </summary>
        [Name("labels.text.fill")]
        LabelsTextFill,

        /// <summary>
        /// Apply the rule to the stroke of the text in the feature's labels.
        /// </summary>
        [Name("labels.text.stroke")]
        LabelsTextStroke,
    }
}
