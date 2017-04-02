namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    /// <summary>
    /// A service for computing directions between two or more places.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class DirectionsService
    {
        /// <summary>
        /// Creates a new instance of a DirectionsService that sends directions queries to Google servers.
        /// </summary>
        public extern DirectionsService();

        /// <summary>
        /// Issue a directions search request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public extern void Route(DirectionsRequest request, Action<DirectionsResult, DirectionsStatus> callback);
    }
}