namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// The response to a DistanceMatrixService request, consisting of the formatted origin and destination addresses, and a sequence of DistanceMatrixResponseRows, one for each corresponding origin address.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class DistanceMatrixResponse
    {
        /// <summary>
        /// The formatted destination addresses.
        /// </summary>
        public string[] DestinationAddresses;

        /// <summary>
        /// The formatted origin addresses.
        /// </summary>
        public string[] OriginAddresses;

        /// <summary>
        /// The rows of the matrix, corresponding to the origin addresses.
        /// </summary>
        public DistanceMatrixResponseRow[] Rows;
    }
}