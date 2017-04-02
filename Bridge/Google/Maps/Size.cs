namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The size.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Size
    {
        /// <summary>
        /// The height along the y-axis, in pixels.
        /// </summary>
        public int Height;

        /// <summary>
        /// The width along the x-axis, in pixels.
        /// </summary>
        public int Width;

        /// <summary>
        /// Two-dimensonal size, where width is the distance on the x-axis, and
        /// height is the distance on the y-axis.
        /// </summary>
        /// <param name="width">The width.</param>
        /// <param name="height">The height.</param>
        /// <param name="widthUnit">Width unit.</param>
        /// <param name="heightUnit">Height unit.</param>
        public extern Size(int width, int height, string widthUnit = null, string heightUnit = null);

        /// <summary>
        /// Compares two Sizes.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool Equals(Size other);

        /// <summary>
        /// Returns a string representation of this Size.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override extern string ToString();
    }
}
