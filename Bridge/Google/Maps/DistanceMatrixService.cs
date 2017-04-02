namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    /// <summary>
    /// A service for computing distances between multiple origins and
    /// destinations.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class DistanceMatrixService
    {
        /// <summary>
        /// Creates a new instance of a DistanceMatrixService that sends
        /// distance matrix queries to Google servers.
        /// </summary>
        public extern DistanceMatrixService();

        /// <summary>
        /// Issues a distance matrix request.
        /// </summary>
        /// <param name="request">
        /// The request.
        /// </param>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public extern void GetDistanceMatrix(
            DistanceMatrixRequest request, 
            Action<DistanceMatrixResponse, DistanceMatrixStatus> callback);
    }
}
