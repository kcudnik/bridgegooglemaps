namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Namespace("google.maps")]
    public class OverlayView: MVCObject
    {
        // TODO delegate
        public extern virtual void Draw();

        public extern Union<Map, StreetViewPanorama> GetMap();

        public extern MapPanes GetPanes();

        public extern MapCanvasProjection GetProjection();

        // TODO delegate
        public extern virtual void OnAdd();

        // TODO delegate
        public extern virtual void OnRemove();

        public extern void SetMap(Union<Map, StreetViewPanorama> map);
    }
}