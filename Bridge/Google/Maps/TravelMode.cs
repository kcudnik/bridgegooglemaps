namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The valid travel modes that can be specified in a DirectionsRequest as
    /// well as the travel modes returned in a DirectionsStep.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum TravelMode
    {
        /// <summary>
        /// Specifies a bicycling directions request.
        /// </summary>
        [Name("BICYCLING")]
        Bicycling,

        /// <summary>
        /// Specifies a driving directions request.
        /// </summary>
        [Name("DRIVING")]
        Driving,

        /// <summary>
        /// Specifies a transit directions request.
        /// </summary>
        [Name("TRANSIT")]
        Transit,

        /// <summary>
        /// Specifies a walking directions request.
        /// </summary>
        [Name("WALKING")]
        Walking
    }
}
