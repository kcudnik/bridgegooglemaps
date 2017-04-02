namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// These options specify the appearance of a marker label.
    /// A marker label is a single character of text which will appear inside the marker.
    /// If you are using it with a custom marker, you can reposition it with the labelOrigin property in the Icon class.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MarkerLabel
    {
        /// <summary>
        /// The color of the label text. Default color is black.
        /// </summary>
        public string Color;

        /// <summary>
        /// The font family of the label text (equivalent to the CSS font-family property).
        /// </summary>
        public string FontFamily;

        /// <summary>
        /// The font size of the label text (equivalent to the CSS font-size property). Default size is 14px.
        /// </summary>
        public string FontSize;

        /// <summary>
        /// The font weight of the label text (equivalent to the CSS font-weight property).
        /// </summary>
        public string FontWeight;

        /// <summary>
        /// The text to be displayed in the label. Only the first character of this string will be shown.
        /// </summary>
        public string Text;
    }
}