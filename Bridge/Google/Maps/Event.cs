namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    /// <summary>
    /// The event.
    /// </summary>
    [External]
    [Name("google.maps.event")]
    [Namespace(false)]
    public static class Event
    {
        /// <summary>
        /// Cross browser event handler registration. This listener is removed by calling removeListener(handle) for the handle that is returned by this function.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <param name="capture">
        /// The capture.
        /// </param>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddDomListener(object instance, string eventName, Action handler, bool capture = false);

        /// <summary>
        /// Cross browser event handler registration. This listener is removed by calling removeListener(handle) for the handle that is returned by this function.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <param name="capture">
        /// The capture.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddDomListener<T>(object instance, string eventName, Action<T> handler, bool capture = false);

        /// <summary>
        /// Wrapper around addDomListener that removes the listener after the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <param name="capture">
        /// The capture.
        /// </param>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddDomListenerOnce(object instance, string eventName, Action handler, bool capture = false);

        /// <summary>
        /// Wrapper around addDomListener that removes the listener after the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <param name="capture">
        /// The capture.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddDomListenerOnce<T>(object instance, string eventName, Action<T> handler, bool capture = false);

        /// <summary>
        /// Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListener<T>(object instance, string eventName, T handler);

        /// <summary>
        /// Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListener(object instance, string eventName, Action handler);

        /// <summary>
        /// Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListener<T>(object instance, string eventName, Action<T> handler);

        /// <summary>
        /// Adds the given listener function to the given event name for the given object instance. Returns an identifier for this listener that can be used with removeListener().
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter T.
        /// </typeparam>
        /// <typeparam name="U">
        /// Template parameter U.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListener<T, U>(object instance, string eventName, Action<T, U> handler);

        /// <summary>
        /// Like addListener, but the handler removes itself after handling the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListenerOnce<T>(object instance, string eventName, T handler);

        /// <summary>
        /// Like addListener, but the handler removes itself after handling the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListenerOnce(object instance, string eventName, Action handler);

        /// <summary>
        /// Like addListener, but the handler removes itself after handling the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListenerOnce<T>(object instance, string eventName, Action<T> handler);

        /// <summary>
        /// Like addListener, but the handler removes itself after handling the first event.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <typeparam name="T">
        /// Template parameter T.
        /// </typeparam>
        /// <typeparam name="U">
        /// Template parameter U.
        /// </typeparam>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern static MapsEventListener AddListenerOnce<T, U>(object instance, string eventName, Action<T, U> handler);

        /// <summary>
        /// Removes all listeners for all events for the given instance.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        public extern static void ClearInstanceListeners(object instance);

        /// <summary>
        /// Removes all listeners for the given event for the given instance.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        public extern static void ClearListeners(object instance, string eventName);

        /// <summary>
        /// Removes the given listener, which should have been returned by addListener above. Equivalent to calling listener.remove().
        /// </summary>
        /// <param name="listener">
        /// The listener.
        /// </param>
        public extern static void RemoveListener(MapsEventListener listener);

        /// <summary>
        /// Triggers the given event. All arguments after eventName are passed as arguments to the listeners.
        /// </summary>
        /// <param name="instance">
        /// The instance.
        /// </param>
        /// <param name="eventName">
        /// The event name.
        /// </param>
        /// <param name="args">
        /// The args.
        /// </param>
        public extern static void Trigger(object instance, string eventName, params object[] args);
    }
}
