namespace Bridge.Google.Maps
{
    using System;

    /// <summary>
    ///     Defines a service class that talks directly to Google servers for
    ///     requesting elevation data.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class ElevationService
    {
        /// <summary>
        ///     Creates a new instance of a ElevationService that sends elevation
        ///     queries to Google servers.
        /// </summary>
        public extern ElevationService();

        /// <summary>
        ///     Makes an elevation request along a path, where the elevation data
        ///     are returned as distance-based samples along that path.
        /// </summary>
        /// <param name="request">
        ///     The request.
        /// </param>
        /// <param name="callback">
        ///     The callback.
        /// </param>
        public extern void GetElevationAlongPath(
            PathElevationRequest request,
            Action<ElevationResult[], ElevationStatus> callback);

        /// <summary>
        ///     Makes an elevation request for a list of discrete locations.
        /// </summary>
        /// <param name="request">
        ///     The request.
        /// </param>
        /// <param name="callback">
        ///     The callback.
        /// </param>
        public extern void GetElevationForLocations(
            LocationElevationRequest request,
            Action<ElevationResult[], ElevationStatus> callback);
    }
}