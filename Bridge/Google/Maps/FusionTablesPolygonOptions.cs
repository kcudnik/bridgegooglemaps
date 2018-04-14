namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Options which control the appearance of polygons in a
    ///     FusionTablesLayer.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesPolygonOptions
    {
        /// <summary>
        ///     The fill color, defined by a six-digit hexadecimal number in RRGGBB
        ///     format (e.g. #00AAFF).
        /// </summary>
        public string FillColor;

        /// <summary>
        ///     The fill opacity between 0.0 and 1.0.
        /// </summary>
        public double FillOpacity;

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
        ///     The stroke width in pixels, between 0 and 10.
        /// </summary>
        public double StrokeWeight;
    }
}