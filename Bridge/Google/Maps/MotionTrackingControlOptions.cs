namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the motion tracking control.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class MotionTrackingControlOptions
    {
        /// <summary>
        /// Position id. This is used to specify the position of this control
        /// on the panorama. The default position is RIGHT_BOTTOM.
        /// </summary>
        public ControlPosition Position;
    }
}
