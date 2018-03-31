namespace Bridge.Google.Maps
{
    using Bridge;
    using Bridge.Html5;

    /// <summary>
    /// The marker.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class Marker : MVCObject
    {
        /// <summary>
        /// The maximum default z-index that the API will assign to a marker.
        /// You may set a higher z-index to bring a marker to the front.
        /// </summary>
        [Name("MAX_ZINDEX")]
        public const int MaxZIndex = 0;

        /// <summary>
        /// Creates a marker with the options specified. If a map is specified,
        /// the marker is added to the map upon construction.
        /// Note that the position must be set for the marker to display.
        /// </summary>
        /// <param name="opts">Options parameter.</param>
        public extern Marker(MarkerOptions opts = null);

        /// <summary>
        /// The get animation.
        /// </summary>
        /// <returns>
        /// The <see cref="Animation"/>.
        /// </returns>
        public extern Animation GetAnimation();

        /// <summary>
        /// The get clickable.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetClickable();

        /// <summary>
        /// The get cursor.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public extern string GetCursor();

        /// <summary>
        /// The get draggable.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetDraggable();

        /// <summary>
        /// The get icon.
        /// </summary>
        /// <returns>
        /// The icon.
        /// </returns>
        public extern Union<string, Icon, Symbol> GetIcon();

        /// <summary>
        /// The get label.
        /// </summary>
        /// <returns>
        /// The <see cref="MarkerLabel"/>.
        /// </returns>
        public extern MarkerLabel GetLabel();

        /// <summary>
        /// The get map.
        /// </summary>
        /// <returns>
        /// The map.
        /// </returns>
        public extern Union<Map, StreetViewPanorama> GetMap();

        /// <summary>
        /// The get opacity.
        /// </summary>
        /// <returns>
        /// The <see cref="double"/>.
        /// </returns>
        public extern double GetOpacity();

        /// <summary>
        /// The get place.
        /// </summary>
        /// <returns>
        /// The <see cref="MarkerPlace"/>.
        /// </returns>
        public extern MarkerPlace GetPlace();

        /// <summary>
        /// The get position.
        /// </summary>
        /// <returns>
        /// The <see cref="LatLng"/>.
        /// </returns>
        public extern LatLng GetPosition();

        /// <summary>
        /// The get shape.
        /// </summary>
        /// <returns>
        /// The <see cref="MarkerShape"/>.
        /// </returns>
        public extern MarkerShape GetShape();

        /// <summary>
        /// The get title.
        /// </summary>
        /// <returns>
        /// The <see cref="string"/>.
        /// </returns>
        public extern string GetTitle();

        /// <summary>
        /// The get visible.
        /// </summary>
        /// <returns>
        /// The <see cref="bool"/>.
        /// </returns>
        public extern bool GetVisible();

        /// <summary>
        /// The get z index.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public extern int GetZIndex();

        /// <summary>
        /// Start an animation. Any ongoing animation will be cancelled.
        /// Currently supported animations are: BOUNCE, DROP. Passing in null
        /// will cause any animation to stop.
        /// </summary>
        /// <param name="animation">
        /// The animation.
        /// </param>
        public extern void SetAnimation(AnimationDirection animation);

        /// <summary>
        /// The set clickable.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetClickable(bool flag);

        /// <summary>
        /// The set cursor.
        /// </summary>
        /// <param name="cursor">
        /// The cursor.
        /// </param>
        public extern void SetCursor(string cursor);

        /// <summary>
        /// The set draggable.
        /// </summary>
        /// <param name="flag">
        /// The flag.
        /// </param>
        public extern void SetDraggable(bool flag);

        /// <summary>
        /// The set icon.
        /// </summary>
        /// <param name="icon">
        /// The icon.
        /// </param>
        public extern void SetIcon(Union<string, Icon, Symbol> icon);

        /// <summary>
        /// The set label.
        /// </summary>
        /// <param name="label">
        /// The label.
        /// </param>
        public extern void SetLabel(Union<string, MarkerLabel> label);

        /// <summary>
        /// The set map.
        /// </summary>
        /// <param name="map">
        /// The map.
        /// </param>
        public extern void SetMap(Union<StreetViewPanorama, Map> map);

        /// <summary>
        /// The set opacity.
        /// </summary>
        /// <param name="opacity">
        /// The opacity.
        /// </param>
        public extern void SetOpacity(double opacity);

        /// <summary>
        /// The set options.
        /// </summary>
        /// <param name="options">
        /// The options.
        /// </param>
        public extern void SetOptions(MarkerOptions options);

        /// <summary>
        /// The set place.
        /// </summary>
        /// <param name="place">
        /// The place.
        /// </param>
        public extern void SetPlace(MarkerPlace place);

        /// <summary>
        /// The set position.
        /// </summary>
        /// <param name="latLng">
        /// The lat lng.
        /// </param>
        public extern void SetPosition(Union<LatLng, LatLngLiteral> latLng);

        /// <summary>
        /// The set shape.
        /// </summary>
        /// <param name="shape">
        /// The shape.
        /// </param>
        public extern void SetShape(MarkerShape shape);

        /// <summary>
        /// The set title.
        /// </summary>
        /// <param name="title">
        /// The title.
        /// </param>
        public extern void SetTitle(string title);

        /// <summary>
        /// The set visible.
        /// </summary>
        /// <param name="visible">
        /// The visible.
        /// </param>
        public extern void SetVisible(bool visible);

        /// <summary>
        /// The set z index.
        /// </summary>
        /// <param name="zIndex">
        /// The z index.
        /// </param>
        public extern void SetZIndex(int zIndex);
    }
}
