namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Options which control the appearance of polylines in a
    ///     FusionTablesLayer.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesPolylineOptions
    {
        /// <summary>
        ///     The fill color, defined by a six-digit hexadecimal number in RRGGBB
        ///     format (e.g. #00AAFF).
        /// </summary>
        public string StrokeColor;

        /// <summary>
        ///     The stroke opacity between 0.0 and 1.0.
        /// </summary>
        public double StrokeOpacity;

        /// <summary>
        ///     The stroke width in pixels.
        /// </summary>
        public double StrokeWeight;
    }
}