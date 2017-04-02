namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Specifies the data to retrieve from a Fusion Tables.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesQuery
    {
        /// <summary>
        /// The ID of the Fusion Tables table to display. This ID can be found in the table's URL, as the value of the dsrcid parameter. Required.
        /// </summary>
        public string From;

        /// <summary>
        /// Limit on the number of results returned by the query.
        /// </summary>
        public int Limit;

        /// <summary>
        /// Offset into the sorted results.
        /// </summary>
        public int Offset;

        /// <summary>
        /// The method by which to sort the results. Accepts either of:
        /// A column name.The column name may be suffixed with ASC or DESC(e.g.col2 DESC) to specify ascending or descending sort.
        /// An ST_DISTANCE spatial relationship (sort by distance). A column and the coordinate from which to calculate distance must be passed, for example, orderBy: 'ST_DISTANCE(col1, LATLNG(1.2, 3.4))'.
        /// </summary>
        public string OrderBy;

        /// <summary>
        /// A column, containing geographic features to be displayed on the map. See Fusion Tables Setup in the Maps API documentation for information about valid columns.
        /// </summary>
        public string Select;

        /// <summary>
        /// The SQL predicate to be applied to the layer.
        /// </summary>
        public string Where;
    }
}