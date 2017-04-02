namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// An elevation request sent by the ElevationService containing the list of discrete coordinates (LatLngs) for which to return elevation data.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class LocationElevationRequest
    {
        /// <summary>
        /// The discrete locations for which to retrieve elevations.
        /// </summary>
        public LatLng[] Locations;
    }
}