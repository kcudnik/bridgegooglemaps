namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A Street View request to be sent with getPanorama.
    /// StreetViewLocationRequest lets you search for a Street View panoroma at
    /// a specified location.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StreetViewLocationRequest
    {
        /// <summary>
        /// Specifies the location where to search for a Street View panorama.
        /// </summary>
        public Union<LatLng, LatLngLiteral> Location;

        /// <summary>
        /// Sets a preference for which panorama should be found within the
        /// radius: the one nearest to the provided location, or the best one
        /// within the radius.
        /// </summary>
        public StreetViewPreference Preference;

        /// <summary>
        /// Sets a radius in meters in which to search for a panorama. Defaults
        /// to 50 when not supplied.
        /// </summary>
        public double Radius;

        /// <summary>
        /// Specifies the source of panoramas to search. This allows a
        /// restriction to search for just outdoor panoramas for example. If
        /// not specified it is set to DEFAULT.
        /// </summary>
        public StreetViewSource Source;
    }
}
