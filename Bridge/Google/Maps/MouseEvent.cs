namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class MouseEvent
    {
        public LatLng LatLng;

        public Point Pixel;

        // TODO could be property
        public extern void Stop();
    }
}