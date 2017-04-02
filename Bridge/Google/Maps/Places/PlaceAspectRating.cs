namespace Bridge.Google.Maps.Places
{
    using Bridge;

    /// <summary>
    /// Defines information about an aspect of the place that users have
    /// reviewed.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PlaceAspectRating
    {
        /// <summary>
        /// he rating of this aspect. For individual reviews this is an integer
        /// from 0 to 3. For aggregated ratings of a place this is an integer
        /// from 0 to 30.
        /// </summary>
        public int Rating;

        /// <summary>
        /// he aspect type, e.g. "food", "decor", "service", "overall".
        /// </summary>
        public string Type;
    }
}
