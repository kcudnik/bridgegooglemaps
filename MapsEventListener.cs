namespace Bridge.Google.Maps
{
    // NOTE: no constructor, internally created

    /// <summary>
    ///     An event listener, created by google.maps.event.addListener() and
    ///     friends.
    /// </summary>
    [External]
    [ObjectLiteral]
    [Namespace("google.maps")]
    public class MapsEventListener
    {
        /// <summary>
        ///     Removes the listener.
        ///     Calling listener.remove() is equivalent to
        ///     google.maps.event.removeListener(listener).
        /// </summary>
        public extern void Remove();
    }
}