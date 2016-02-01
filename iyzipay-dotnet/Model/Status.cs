using System;

namespace Iyzipay.Model
{
    public sealed class Status
    {
        private readonly String name;
        private readonly int value;

        public static readonly Status SUCCESS = new Status(1, "success");
        public static readonly Status FAILURE = new Status(2, "failure");

        private Status(int value, String name)
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
