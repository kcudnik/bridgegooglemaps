namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A LatLng is a point in geographical coordinates: latitude and longitude.
    /// Latitude ranges between -90 and 90 degrees, inclusive.Values above or below this range will be clamped to the range[-90, 90]. This means that if the value specified is less than -90, it will be set to -90. And if the value is greater than 90, it will be set to 90.
    /// Longitude ranges between -180 and 180 degrees, inclusive.Values above or below this range will be wrapped so that they fall within the range.For example, a value of -190 will be converted to 170. A value of 190 will be converted to -170. This reflects the fact that longitudes wrap around the globe.
    /// Although the default map projection associates longitude with the x-coordinate of the map, and latitude with the y-coordinate, the latitude coordinate is always written first, followed by the longitude.
    /// Notice that you cannot modify the coordinates of a LatLng. If you want to compute another point, you have to create a new one.
    /// Most methods that accept LatLng objects also accept a LatLngLiteral object, so that the following are equivalent:
    /// map.setCenter(new google.maps.LatLng(-34, 151));
    /// map.setCenter({lat: -34, lng: 151});
    /// The constructor also accepts literal objects, and converts them to instances of LatLng:
    /// myLatLng = new google.maps.LatLng({lat: -34, lng: 151});
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class LatLng
    {
        /// <summary>
        /// Creates a LatLng object representing a geographic point. Latitude is specified in degrees within the range [-90, 90]. Longitude is specified in degrees within the range [-180, 180]. Set noWrap to true to enable values outside of this range. Note the ordering of latitude and longitude.
        /// </summary>
        /// <param name="lat">Latitude value.</param>
        /// <param name="lng">Longitude value.</param>
        /// <param name="noWrap">No wrap param.</param>
        public extern LatLng(double lat, double lng, bool noWrap = false);

        /// <summary>
        /// Comparison function.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool Equals(LatLng other);

        /// <summary>
        /// Returns the latitude in degrees.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public extern double Lat();

        /// <summary>
        /// Returns the longitude in degrees.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public extern double Lng();

        /// <summary>
        /// Converts to JSON representation. This function is intended to be used via JSON.stringify.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override extern string ToString();

        /// <summary>
        /// Returns a string of the form "lat,lng" for this LatLng. We round the lat/lng values to 6 decimal places by default.
        /// </summary>
        /// <param name="precision">
        /// The precision.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public extern string ToUrlValue(double precision = 6);
    }
}