namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Controls the appearance of a set of features within a
    ///     FusionTablesLayer.
    ///     Features which match the provided SQL predicate will be styled with the
    ///     supplied options.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesStyle
    {
        /// <summary>
        ///     Options which control the appearance of point features.
        /// </summary>
        public FusionTablesMarkerOptions MarkerOptions;

        /// <summary>
        ///     Options which control the appearance of polygons.
        /// </summary>
        public FusionTablesPolygonOptions PolygonOptions;

        /// <summary>
        ///     Options which control the appearance of polylines.
        /// </summary>
        public FusionTablesPolylineOptions PolylineOptions;

        /// <summary>
        ///     The SQL predicate to be applied to the layer.
        /// </summary>
        public string Where;
    }
}