namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Animations that can be played on a marker. Use the setAnimation method
    ///     on Marker or the animation option to play an animation.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum Animation
    {
        /// <summary>
        ///     Marker bounces until animation is stopped.
        /// </summary>
        [Name("BOUNCE")]
        Bounce,

        /// <summary>
        ///     Marker falls from the top of the map ending with a small bounce.
        /// </summary>
        [Name("DROP")]
        Drop
    }
}