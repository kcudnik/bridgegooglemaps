namespace Bridge.Google.Maps
{
    using Bridge;
    using System;

    /// <summary>
    /// The MVCObject constructor is guaranteed to be an empty function, and so
    /// you may inherit from MVCObject by simply writing MySubclass.prototype =
    /// new google.maps.MVCObject();. Unless otherwise noted, this is not true
    /// of other classes in the API, and inheriting from other classes in the
    /// API is not supported.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class MVCObject
    {
        /// <summary>
        /// Creates an MVCObject.
        /// </summary>
        public extern MVCObject();

        /// <summary>
        /// Adds the given listener function to the given event name. Returns
        /// an identifier for this listener that can be used with
        /// google.maps.event.removeListener.
        /// </summary>
        /// <param name="name">
        /// The name.
        /// </param>
        /// <param name="handler">
        /// The handler.
        /// </param>
        /// <returns>
        /// The <see cref="MapsEventListener"/>.
        /// </returns>
        public extern MapsEventListener AddListener(string name, Action handler);

        /// <summary>
        /// Binds a View to a Model.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="target">
        /// The target.
        /// </param>
        /// <param name="targetKey">
        /// The target key.
        /// </param>
        /// <param name="noNotify">
        /// The no notify.
        /// </param>
        public extern void BindTo(string key, MVCObject target, string targetKey = null, bool noNotify = false);

        /// <summary>
        /// Gets a value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <returns>
        /// The <see cref="object"/>.
        /// </returns>
        public extern object Get(string key);

        /// <summary>
        /// Notify all observers of a change on this property. This notifies
        /// both objects that are bound to the object's property as well as the
        /// object that it is bound to.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        public extern void Notify(string key);

        /// <summary>
        /// Sets a value.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        /// <param name="value">
        /// The value.
        /// </param>
        public extern void Set(string key, object value);

        /// <summary>
        /// Sets a collection of key-value pairs.
        /// </summary>
        /// <param name="values">
        /// The values.
        /// </param>
        public extern void SetValues(object values);

        /// <summary>
        /// Removes a binding. Unbinding will set the unbound property to the
        /// current value. The object will not be notified, as the value has
        /// not changed.
        /// </summary>
        /// <param name="key">
        /// The key.
        /// </param>
        public extern void Unbind(string key);

        /// <summary>
        /// Removes all bindings.
        /// </summary>
        public extern void UnbindAll();
    }
}
