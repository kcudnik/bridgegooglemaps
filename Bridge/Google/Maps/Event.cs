namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    [External]
    [Name("google.maps.event")]
    [Namespace(false)]
    public static class Event
    {
        public extern static MapsEventListener AddDomListener(object instance, string eventName, Action handler, bool capture = false);

        public extern static MapsEventListener AddDomListener<T>(object instance, string eventName, Action<T> handler, bool capture = false);

        public extern static MapsEventListener AddDomListenerOnce(
            object instance, string eventName, Action handler, bool capture = false);

        public extern static MapsEventListener AddDomListenerOnce<T>(
            object instance, string eventName, Action<T> handler, bool capture = false);

        public extern static MapsEventListener AddListener<T>(object instance, string eventName, T handler);

        public extern static MapsEventListener AddListener(object instance, string eventName, Action handler);

        public extern static MapsEventListener AddListener<T>(object instance, string eventName, Action<T> handler);

        public extern static MapsEventListener AddListener<T, U>(object instance, string eventName, Action<T, U> handler);

        public extern static MapsEventListener AddListenerOnce<T>(object instance, string eventName, T handler);

        public extern static MapsEventListener AddListenerOnce(object instance, string eventName, Action handler);

        public extern static MapsEventListener AddListenerOnce<T>(object instance, string eventName, Action<T> handler);

        public extern static MapsEventListener AddListenerOnce<T, U>(object instance, string eventName, Action<T, U> handler);

        public extern static void ClearInstanceListeners(object instance);

        public extern static void ClearListeners(object instance, string eventName);

        public extern static void RemoveListener(MapsEventListener listener);

        public extern static void Trigger(object instance, string eventName, params object[] args);
    }
}