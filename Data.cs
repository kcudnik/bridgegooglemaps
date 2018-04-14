namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A layer for displaying geospatial data. Points, line-strings and
    ///     polygons can be displayed.
    ///     Every Map has a Data object by default, so most of the time there is no
    ///     need to construct one.For example:
    ///     var myMap = new google.maps.Map(...);
    ///     myMap.data.addGeoJson(...);
    ///     myMap.data.setStyle(...);
    ///     The Data object is a collection of Features.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class Data : MVCObject
    {
        // TODO populate
    }
}