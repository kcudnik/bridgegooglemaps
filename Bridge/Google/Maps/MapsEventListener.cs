namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// An event listener, created by google.maps.event.addListener() and friends.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class MapsEventListener
    {
        /// <summary>
        /// Removes the listener.
        /// Calling listener.remove() is equivalent to google.maps.event.removeListener(listener).
        /// </summary>
        public extern void Remove();
    }
}
