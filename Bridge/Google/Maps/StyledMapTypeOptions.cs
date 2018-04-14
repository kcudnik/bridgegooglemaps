namespace Bridge.Google.Maps
{
    /// <summary>
    ///     This class is used to specify options when creating a StyledMapType.
    ///     These options cannot be changed after the StyledMapType is
    ///     instantiated.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class StyledMapTypeOptions
    {
        /// <summary>
        ///     Text to display when this MapType's button is hovered over in the
        ///     map type control.
        /// </summary>
        public string Alt;

        /// <summary>
        ///     The maximum zoom level for the map when displaying this MapType.
        ///     Optional.
        /// </summary>
        public int MaxZoom;

        /// <summary>
        ///     The minimum zoom level for the map when displaying this MapType.
        ///     Optional.
        /// </summary>
        public int MinZoom;

        /// <summary>
        ///     The name to display in the map type control.
        /// </summary>
        public string Name;
    }
}