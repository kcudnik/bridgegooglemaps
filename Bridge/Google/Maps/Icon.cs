namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The icon.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Icon
    {
        /// <summary>
        /// The position at which to anchor an image in correspondence to the
        /// location of the marker on the map. By default, the anchor is
        /// located along the center point of the bottom of the image.
        /// </summary>
        public Point Anchor;

        /// <summary>
        /// The origin of the label relative to the top-left corner of the icon
        /// image, if a label is supplied by the marker. By default, the origin
        /// is located in the center point of the image.
        /// </summary>
        public Point LabelOrigin;

        /// <summary>
        /// The position of the image within a sprite, if any. By default, the
        /// origin is located at the top left corner of the image (0, 0).
        /// </summary>
        public Point Origin;

        /// <summary>
        /// The size of the entire image after scaling, if any. Use this
        /// property to stretch/shrink an image or a sprite.
        /// </summary>
        public Size ScaledSize;

        /// <summary>
        /// The display size of the sprite or image. When using sprites, you
        /// must specify the sprite size. If the size is not provided, it will
        /// be set when the image loads.
        /// </summary>
        public Size Size;

        /// <summary>
        /// The URL of the image or sprite sheet.
        /// </summary>
        public string Url;
    }
}
