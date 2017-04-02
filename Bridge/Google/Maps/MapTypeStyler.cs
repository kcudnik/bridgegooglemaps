namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A styler affects how a map's elements will be styled. Each MapTypeStyler should contain one and only one key.
    /// If more than one key is specified in a single MapTypeStyler, all but one will be ignored. For example: var rule = {hue: '#ff0000'}.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MapTypeStyler
    {
        /// <summary>
        /// Sets the color of the feature. Valid values: An RGB hex string, i.e. '#ff0000'.
        /// </summary>
        public string Color;

        /// <summary>
        /// Modifies the gamma by raising the lightness to the given power. Valid values: Floating point numbers, [0.01, 10], with 1.0 representing no change.
        /// </summary>
        public double Gamma;

        /// <summary>
        /// Sets the hue of the feature to match the hue of the color supplied. Note that the saturation and lightness of the feature is conserved, which means that the feature will not match the color supplied exactly. Valid values: An RGB hex string, i.e. '#ff0000'.
        /// </summary>
        public string Hue;

        /// <summary>
        /// A value of true will invert the lightness of the feature while preserving the hue and saturation.
        /// </summary>
        [Name("invert_lightness")]
        public bool InvertLightness;

        /// <summary>
        /// Shifts lightness of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public double Lightness;

        /// <summary>
        /// Shifts the saturation of colors by a percentage of the original value if decreasing and a percentage of the remaining value if increasing. Valid values: [-100, 100].
        /// </summary>
        public double Saturation;

        /// <summary>
        /// Sets the visibility of the feature. Valid values: 'on', 'off' or 'simplified'.
        /// </summary>
        public string Visibility;

        /// <summary>
        /// Sets the weight of the feature, in pixels. Valid values: Integers greater than or equal to zero.
        /// </summary>
        public double Weight;
    }
}