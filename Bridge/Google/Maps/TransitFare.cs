namespace Bridge.Google.Maps
{
    using Bridge;

    /// <summary>
    /// A fare of a DirectionsRoute consisting of value and currency.
    /// </summary>
    [External]
    [ObjectLiteral]
    public class TransitFare
    {
        /// <summary>
        /// An ISO 4217 currency code indicating the currency in which the fare
        /// is expressed.
        /// </summary>
        public string Currency;

        /// <summary>
        /// The numerical value of the fare, expressed in the given currency.
        /// </summary>
        public double Value;
    }
}
