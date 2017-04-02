namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the fullscreen control.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FullscreenControlOptions
    {
        /// <summary>
        /// Position id. Used to specify the position of the control on the
        /// map. The default position is RIGHT_TOP.
        /// </summary>
        public ControlPosition Position;
    }
}
