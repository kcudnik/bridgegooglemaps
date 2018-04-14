namespace Bridge.Google.Maps
{
    /// <summary>
    ///     A row of the response to a DistanceMatrixService request, consisting of
    ///     a sequence of DistanceMatrixResponseElements, one for each
    ///     corresponding destination address.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DistanceMatrixResponseRow
    {
        /// <summary>
        ///     The row's elements, corresponding to the destination addresses.
        /// </summary>
        public DistanceMatrixResponseElement[] Elements;
    }
}