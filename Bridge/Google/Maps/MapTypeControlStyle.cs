namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Identifiers for common MapTypesControls.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeControlStyle
    {
        /// <summary>
        /// Uses the default map type control. When the DEFAULT control is
        /// shown, it will vary according to window size and other factors. The
        /// DEFAULT control may change in future versions of the API.
        /// </summary>
        [Name("DEFAULT")]
        Default,

        /// <summary>
        /// A dropdown menu for the screen realestate conscious.
        /// </summary>
        [Name("DROPDOWN_MENU")]
        DropDownMenu,

        /// <summary>
        /// The standard horizontal radio buttons bar.
        /// </summary>
        [Name("HORIZONTAL_BAR")]
        HorizontalBar
    }
}
