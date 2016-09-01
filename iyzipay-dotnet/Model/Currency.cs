using System;

namespace Iyzipay.Model
{
    public sealed class Currency
    {
        private readonly String name;
        private readonly int value;

        public static readonly Currency TRY = new Currency(1, "TRY");
        public static readonly Currency EUR = new Currency(2, "EUR");
        public static readonly Currency USD = new Currency(3, "USD");
        public static readonly Currency GBP = new Currency(4, "GBP");
        public static readonly Currency IRR = new Currency(5, "IRR");

        private Currency(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public override String ToString()
        {
            return name;
        }

    }
}
