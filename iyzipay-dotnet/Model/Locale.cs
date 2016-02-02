using System;

namespace Iyzipay.Model
{
    public sealed class Locale
    {
        private readonly String name;
        private readonly int value;

        public static readonly Locale EN = new Locale(1, "en");
        public static readonly Locale TR = new Locale(2, "tr");

        private Locale(int value, String name)
        {
            this.name = name;
            this.value = value;
        }

        public String GetName()
        {
            return name;
        }

    }
}
