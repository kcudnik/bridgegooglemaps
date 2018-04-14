namespace Bridge.Google.Maps.Places
{
    /// <summary>
    ///     The options that can be set on a SearchBox object.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class SearchBoxOptions
    {
        /// <summary>
        ///     The area towards which to bias query predictions. Predictions are
        ///     biased towards, but not restricted to, queries targeting these
        ///     bounds.
        /// </summary>
        public Union<LatLngBounds, LatLngBoundsLiteral> Bounds;
    }
}