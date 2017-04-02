namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Specifies the appearance for a FusionTablesLayer when rendered as a
    /// heatmap.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class FusionTablesHeatmap
    {
        /// <summary>
        /// If true, render the layer as a heatmap.
        /// </summary>
        public bool Enabled;
    }
}
