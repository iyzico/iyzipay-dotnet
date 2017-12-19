using System;

namespace Iyzipay.Model
{
    public sealed class RefundReason
    {
        private readonly String value;

        public static readonly RefundReason DOUBLE_PAYMENT = new RefundReason("double_payment");
        public static readonly RefundReason BUYER_REQUEST = new RefundReason("buyer_request");
        public static readonly RefundReason FRAUD = new RefundReason("fraud");
        public static readonly RefundReason OTHER = new RefundReason("other");

        private RefundReason(String value)
        {
            this.value = value;
        }

        public override string ToString()
        {
            return value;
        }
    }
}