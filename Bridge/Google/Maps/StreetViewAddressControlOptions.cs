namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options for the rendering of the Street View address control.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewAddressControlOptions
    {
        /// <summary>
        /// Position id. This id is used to specify the position of the control on the map. The default position is TOP_LEFT.
        /// </summary>
        public ControlPosition Position;
    }
}