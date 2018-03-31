namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A LatLngBounds instance represents a rectangle in geographical
    /// coordinates, including one that crosses the 180 degrees longitudinal
    /// meridian.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class LatLngBounds
    {
        /// <summary>
        /// Constructs a rectangle from the points at its south-west and
        /// north-east corners.
        /// </summary>
        /// <param name="sw">South west.</param>
        /// <param name="ne">North east.</param>
        public extern LatLngBounds(LatLng sw = null, LatLng ne = null);

        /// <summary>
        /// Returns true if the given lat/lng is in this bounds.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool Contains(Union<LatLng, LatLngLiteral> latLng);

        /// <summary>
        /// Returns true if this bounds approximately equals the given bounds.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool Equals(LatLngBounds other);

        /// <summary>
        /// Extends this bounds to contain the given point.
        /// </summary>
        /// <param name="point">
        /// The point.
        /// </param>
        /// <returns>
        /// The <see cref="LatLngBounds"/>.
        /// </returns>
        public extern LatLngBounds Extend(Union<LatLng, LatLngLiteral> point);

        /// <summary>
        /// Computes the center of this LatLngBounds
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng GetCenter();

        /// <summary>
        /// Returns the north-east corner of this bounds.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng GetNorthEast();

        /// <summary>
        /// Returns the south-west corner of this bounds.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng GetSouthWest();

        /// <summary>
        /// Returns true if this bounds shares any points with the other
        /// bounds.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool Intersects(LatLngBounds other);

        /// <summary>
        /// Returns if the bounds are empty.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool IsEmpty();

        /// <summary>
        /// Converts to JSON representation. This function is intended to be
        /// used via JSON.stringify.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLngBoundsLiteral"/>.
        /// </returns>
        public extern LatLngBoundsLiteral ToJSON();

        /// <summary>
        /// Converts the given map bounds to a lat/lng span.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng ToSpan();

        /// <summary>
        /// Converts to string.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public override extern string ToString();

        /// <summary>
        /// Returns a string of the form "lat_lo,lng_lo,lat_hi,lng_hi" for this
        /// bounds, where "lo" corresponds to the southwest corner of the
        /// bounding box, while "hi" corresponds to the northeast corner of
        /// that box.
        /// </summary>
        /// <param name="precision">
        /// The precision.
        /// </param>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public extern string ToUrlValue(double precision = 0);

        /// <summary>
        /// Extends this bounds to contain the union of this and the given
        /// bounds.
        /// </summary>
        /// <param name="other">
        /// The other.
        /// </param>
        /// <returns>
        /// The <see cref="LatLngBounds"/>.
        /// </returns>
        public extern LatLngBounds Union(Union<LatLngBounds, LatLngBoundsLiteral> other);
    }
}
