namespace Bridge.Google.Maps
{
    /// <summary>
    ///     Options for the Custom Pano Provider.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class PanoProviderOptions
    {
        /// <summary>
        ///     If set, the renderer will use technologies (like webgl) that only
        ///     work when cors headers are appropiately set on the provided images.
        ///     It is the developer's task to serve the images correctly in
        ///     combination with this flag, which might otherwise lead to
        ///     SecurityErrors.
        /// </summary>
        public bool Cors;
    }
}