namespace Bridge.Google.Maps
{
    using System;

    using Bridge;

    /// <summary>
    /// The mvc array.
    /// </summary>
    /// <typeparam name="T">
    /// Template parameter.
    /// </typeparam>
    [External]
    [Namespace("google.maps")]
    [Name("google.maps.MVCArray")]
    [IgnoreGeneric]
    public class MVCArray<T> : MVCObject
    {
        /// <summary>
        /// A mutable MVC Array.
        /// </summary>
        [Template("new google.maps.MVCArray()")]
        public extern MVCArray();

        /// <summary>
        /// A mutable MVC Array.
        /// </summary>
        /// <param name="array">
        /// Initial array.
        /// </param>
        [Template("new google.maps.MVCArray({array})")]
        public extern MVCArray(T[] array);

        /// <summary>
        /// Removes all elements from the array.
        /// </summary>
        public extern void Clear();

        /// <summary>
        /// Iterate over each element, calling the provided callback. The
        /// callback is called for each element like: callback(element, index).
        /// </summary>
        /// <param name="callback">
        /// The callback.
        /// </param>
        public extern void ForEach(Action<T, int> callback);

        /// <summary>
        /// Returns a reference to the underlying Array. Warning: if the Array
        /// is mutated, no events will be fired by this object.
        /// </summary>
        /// <returns>
        /// The array.
        /// </returns>
        public extern T[] GetArray();

        /// <summary>
        /// Returns the element at the specified index.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <returns>
        /// The element at position i.
        /// </returns>
        public extern T GetAt(int i);

        /// <summary>
        /// Returns the number of elements in this array.
        /// </summary>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public extern int GetLength();

        /// <summary>
        /// Inserts an element at the specified index.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <param name="elem">
        /// The elem.
        /// </param>
        public extern void InsertAt(int i, T elem);

        /// <summary>
        /// Removes the last element of the array and returns that element.
        /// </summary>
        /// <returns>
        /// The element.
        /// </returns>
        public extern T Pop();

        /// <summary>
        /// Adds one element to the end of the array and returns the new length
        /// of the array.
        /// </summary>
        /// <param name="elem">
        /// The elem.
        /// </param>
        /// <returns>
        /// The <see cref="int"/>.
        /// </returns>
        public extern int Push(T elem);

        /// <summary>
        /// Removes an element from the specified index.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <returns>
        /// The removed element.
        /// </returns>
        public extern T RemoveAt(int i);

        /// <summary>
        /// Sets an element at the specified index.
        /// </summary>
        /// <param name="i">
        /// The i.
        /// </param>
        /// <param name="elem">
        /// The elem.
        /// </param>
        public extern void SetAt(int i, T elem);
    }
}
