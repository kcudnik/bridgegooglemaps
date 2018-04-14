namespace Bridge.Google.Maps
{
    using System;

    /// <summary>
    ///     A StreetViewService object performs searches for Street View data.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class StreetViewService
    {
        /// <summary>
        ///     Creates a StreetViewService, which provides an interface to the
        ///     data stored in the Street View service.
        /// </summary>
        public extern StreetViewService();

        /// <summary>
        ///     Retrieves the StreetViewPanoramaData for a panorama that matches
        ///     the supplied Street View query request. The StreetViewPanoramaData
        ///     is passed to the provided callback.
        /// </summary>
        /// <param name="request">The request.</param>
        /// <param name="callback">The callback.</param>
        public extern void GetPanorama(
            Union<StreetViewLocationRequest, StreetViewPanoRequest> request,
            Action<StreetViewPanoramaData, StreetViewStatus> callback);
    }
}