namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The status returned by KmlLayer on the completion of loading a document.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum KmlLayerStatus
    {
        /// <summary>
        /// The document could not be found. Most likely it is an invalid URL, or the document is not publicly available.
        /// </summary>
        [Name("DOCUMENT_NOT_FOUND")]
        DocumentNotFound,

        /// <summary>
        /// The document exceeds the file size limits of KmlLayer.
        /// </summary>
        [Name("DOCUMENT_TOO_LARGE")]
        DocumentTooLarge,

        /// <summary>
        /// The document could not be fetched.
        /// </summary>
        [Name("FETCH_ERROR")]
        FetchError,

        /// <summary>
        /// The document is not a valid KML, KMZ or GeoRSS document.
        /// </summary>
        [Name("INVALID_DOCUMENT")]
        InvalidDocument,

        /// <summary>
        /// The KmlLayer is invalid.
        /// </summary>
        [Name("INVALID_REQUEST")]
        InvalidRequest,

        /// <summary>
        /// The document exceeds the feature limits of KmlLayer.
        /// </summary>
        [Name("LIMITS_EXCEEDED")]
        LimitsExceeded,

        /// <summary>
        /// The layer loaded successfully.
        /// </summary>
        [Name("OK")]
        Ok,

        /// <summary>
        /// The document could not be loaded within a reasonable amount of time.
        /// </summary>
        [Name("TIMED_OUT")]
        TimedOut,

        /// <summary>
        /// The document failed to load for an unknown reason.
        /// </summary>
        [Name("UNKNOWN")]
        Unknown
    }
}
