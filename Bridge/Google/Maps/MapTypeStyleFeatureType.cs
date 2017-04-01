namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [Enum(Emit.Name)]
    [Namespace("google.maps")]
    public enum MapTypeStyleFeatureType
    {
        [Name("all")]
        All,

        [Name("administrative")]
        Administrative,
        // TODO rest
    }
}