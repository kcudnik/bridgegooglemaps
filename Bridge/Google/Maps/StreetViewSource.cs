namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Identifiers to limit Street View searches to selected sources.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum StreetViewSource
    {
        /// <summary>
        /// Uses the default sources of Street View, searches will not be limited to specific sources.
        /// </summary>
        [Name("DEFAULT")]
        Default,

        /// <summary>
        /// Limits Street View searches to outdoor collections. Indoor collections are not included in search results. Note also that the search only returns panoramas where it's possible to determine whether they're indoors or outdoors. For example, PhotoSpheres are not returned because it's unknown whether they are indoors or outdoors.
        /// </summary>
        [Name("OUTDOOR")]
        Outdoor
    }
}