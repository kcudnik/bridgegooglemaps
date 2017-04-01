namespace Bridge.Google.Maps
{
    using Bridge;

    [External]
    [ObjectLiteral]
    public class MapTypeControlOptions
    {
        public Union<string, MapTypeId>[] MapTypeIds;

        public ControlPosition Position;

        public MapTypeControlStyle Style;
    }
}