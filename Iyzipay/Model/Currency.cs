using System;

namespace Iyzipay.Model
{
    public sealed class Currency
    {
        private readonly String value;

        public static readonly Currency TRY = new Currency("TRY");
        public static readonly Currency EUR = new Currency("EUR");
        public static readonly Currency USD = new Currency("USD");
        public static readonly Currency GBP = new Currency("GBP");
        public static readonly Currency IRR = new Currency("IRR");
        public static readonly Currency NOK = new Currency("NOK");
        public static readonly Currency RUB = new Currency("RUB");
        public static readonly Currency CHF = new Currency("CHF");

        private Currency(String value)
        {
            this.value = value;
        }

        public override String ToString()
        {
            return value;
        }
    }
}
