namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Options that bias a search result towards returning a Street View
    /// panorama that is nearest to the request location, or a panorama that is
    /// considered most likely to be what the user wants to see.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewPreference
    {
        /// <summary>
        /// Return the Street View panorama that is considered most likely to
        /// be what the user wants to see. The best result is determined by
        /// algorithms based on user research and parameters such as recognised
        /// points of interest, image quality, and distance from the given
        /// location.
        /// </summary>
        [Name("BEST")]
        Best,

        /// <summary>
        /// Return the Street View panorama that is the shortest distance from
        /// the provided location. This works well only within a limited
        /// radius. The recommended radius is 1km or less.
        /// </summary>
        [Name("NEAREST")]
        Nearest
    }
}
