namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// Identifiers used to specify the placement of controls on the map.
    /// Controls are positioned relative to other controls in the same layout
    /// position.  Controls that are added first are positioned closer to the
    /// edge of the map.
    /// +----------------+
    /// + TL    TC    TR +
    /// + LT          RT +
    /// +                +
    /// + LC          RC +
    /// +                +
    /// + LB          RB +
    /// + BL    BC    BR +
    /// +----------------+
    /// Elements in the top or bottom row flow towards the middle of the row.
    /// Elements in the left or right column flow towards the middle of the
    /// column.
    /// </summary>
    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum ControlPosition
    {
        /// <summary>
        /// Elements are positioned in the center of the bottom row.
        /// </summary>
        [Name("BOTTOM_CENTER")]
        BottomCenter,

        /// <summary>
        /// Elements are positioned in the bottom left and flow towards the
        /// middle. Elements are positioned to the right of the Google logo.
        /// </summary>
        [Name("BOTTOM_LEFT")]
        BottomLeft,

        /// <summary>
        /// Elements are positioned in the bottom right and flow towards the
        /// middle. Elements are positioned to the left of the copyrights.
        /// </summary>
        [Name("BOTTOM_RIGHT")]
        BottomRight,

        /// <summary>
        /// Elements are positioned on the left, above bottom-left elements,
        /// and flow upwards.
        /// </summary>
        [Name("LEFT_BOTTOM")]
        LeftBottom,

        /// <summary>
        /// Elements are positioned in the center of the left side.
        /// </summary>
        [Name("LEFT_CENTER")]
        LeftCenter,

        /// <summary>
        /// Elements are positioned on the left, below top-left elements, and
        /// flow downwards.
        /// </summary>
        [Name("LEFT_TOP")]
        LeftTop,

        /// <summary>
        /// Elements are positioned on the right, above bottom-right elements,
        /// and flow upwards.
        /// </summary>
        [Name("RIGHT_BOTTOM")]
        RightBottom,

        /// <summary>
        /// Elements are positioned in the center of the right side.
        /// </summary>
        [Name("RIGHT_CENTER")]
        RightCenter,

        /// <summary>
        /// Elements are positioned on the right, below top-right elements, and
        /// flow downwards.
        /// </summary>
        [Name("RIGHT_TOP")]
        RightTop,

        /// <summary>
        /// Elements are positioned in the center of the top row.
        /// </summary>
        [Name("TOP_CENTER")]
        TopCenter,

        /// <summary>
        /// Elements are positioned in the top left and flow towards the
        /// middle.
        /// </summary>
        [Name("TOP_LEFT")]
        TopLeft,

        /// <summary>
        /// Elements are positioned in the top right and flow towards the
        /// middle.
        /// </summary>
        [Name("TOP_RIGHT")]
        TopRight
    }
}
