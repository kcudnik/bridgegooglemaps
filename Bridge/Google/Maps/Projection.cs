namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ExternalInterface]
    public interface Projection
    {
        // TODO delegates?
        Point FromLatLngToPoint(LatLng latLng, Point point = null);

        LatLng FromPointToLatLng(Point pixel, bool nowrap = false);
    }
}