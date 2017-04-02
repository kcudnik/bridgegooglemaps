namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A point of view object which specifies the camera's orientation at the
    /// Street View panorama's position. The point of view is defined as
    /// heading and pitch.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewPov
    {
        /// <summary>
        /// The camera heading in degrees relative to true north. True north is
        /// 0, east is 90, south is 180, west is 270.
        /// </summary>
        public double Heading;

        /// <summary>
        /// The camera pitch in degrees, relative to the street view vehicle.
        /// Ranges from 90 (directly upwards) to -90 (directly downwards).
        /// </summary>
        public double Pitch;
    }
}
