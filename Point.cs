namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The point.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Point
    {
        /// <summary>
        ///     The X coordinate
        /// </summary>
        public double X;

        /// <summary>
        ///     The Y coordinate
        /// </summary>
        public double Y;

        /// <summary>
        ///     A point on a two-dimensional plane.
        /// </summary>
        /// <param name="x">The x coordinate.</param>
        /// <param name="y">The y coordinate.</param>
        public extern Point(double x, double y);

        /// <summary>
        ///     Compares two Points.
        /// </summary>
        /// <param name="other">
        ///     The other.
        /// </param>
        /// <returns>
        ///     The <see cref="bool" />.
        /// </returns>
        public extern bool Equals(Point other);

        /// <summary>
        ///     Returns a string representation of this Point.
        /// </summary>
        /// <returns>
        ///     The <see cref="string" />.
        /// </returns>
        public override extern string ToString();
    }
}