namespace Bridge.Google.Maps
{
    /// <summary>
    ///     The possible positions of the stroke on a polygon.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StrokePosition
    {
        /// <summary>
        ///     The stroke is centered on the polygon's path, with half the stroke
        ///     inside the polygon and half the stroke outside the polygon.
        /// </summary>
        [Name("CENTER")]
        Center,

        /// <summary>
        ///     The stroke lies inside the polygon.
        /// </summary>
        [Name("INSIDE")]
        Inside,

        /// <summary>
        ///     The stroke lies outside the polygon.
        /// </summary>
        [Name("OUTSIDE")]
        Outside
    }
}