namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The map type registry.
    /// </summary>
    [External]
    [Namespace("google.maps")]
    public class MapTypeRegistry : MVCObject
    {
        /// <summary>
        /// The MapTypeRegistry holds the collection of custom map types available to the map for its use. The API consults this registry when providing the list of avaiable map types within controls, for example.
        /// </summary>
        public extern MapTypeRegistry();

        /// <summary>
        /// Sets the registry to associate the passed string identifier with the passed MapType.
        /// </summary>
        /// <param name="id">
        /// The id.
        /// </param>
        /// <param name="mapType">
        /// The map type.
        /// </param>
        public extern void Set(string id, MapTypeId mapType);
    }
}