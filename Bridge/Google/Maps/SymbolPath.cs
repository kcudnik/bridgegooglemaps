namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Built-in symbol paths.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum SymbolPath
    {
        /// <summary>
        ///     A backward-pointing closed arrow.
        /// </summary>
        [Name("BACKWARD_CLOSED_ARROW")]
        BackwardClosedArrow,

        /// <summary>
        ///     A backward-pointing open arrow.
        /// </summary>
        [Name("BACKWARD_OPEN_ARROW")]
        BackwardOpenArrow,

        /// <summary>
        ///     A circle.
        /// </summary>
        [Name("CIRCLE")]
        Circle,

        /// <summary>
        ///     A forward-pointing closed arrow.
        /// </summary>
        [Name("FORWARD_CLOSED_ARROW")]
        ForwardClosedArrow,

        /// <summary>
        ///     A forward-pointing open arrow.
        /// </summary>
        [Name("FORWARD_OPEN_ARROW")]
        ForwardOpenedArrow
    }
}