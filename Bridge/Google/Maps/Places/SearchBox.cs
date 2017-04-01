namespace Bridge.Google.Maps.Places
{
    using Bridge;
    using Bridge.Html5;

    public delegate string GetUrlDelegate(PhotoOptions opts);

    [External]
    [Namespace("google.maps.places")]
    public class SearchBox : MVCObject
    {
        public extern SearchBox(HTMLInputElement inputField, SearchBoxOptions opts = null);

        public extern LatLngBounds GetBounds();

        public extern PlaceResult[] GetPlaces();

        public extern void SetBounds(Union<LatLngBounds, LatLngBoundsLiteral> bounds);
    }
}