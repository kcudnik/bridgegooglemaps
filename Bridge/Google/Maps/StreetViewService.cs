namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Namespace("google.maps")]
    public class StreetViewService
    {
        public extern void GetPanorama(Union<StreetViewLocationRequest, StreetViewPanoRequest> request, Action <StreetViewPanoramaData, StreetViewStatus> callback);
    }
}