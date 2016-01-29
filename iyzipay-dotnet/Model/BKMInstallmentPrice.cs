using System;

namespace Iyzipay.Model
{
    class BKMInstallmentPrice : RequestStringConvertible
    {
        public int? InstallmentNumber { get; set; }
        public decimal? TotalPrice { get; set; }

        public String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("installmentNumber", InstallmentNumber)
                .Append("totalPrice", TotalPrice)
                .GetRequestString();
        }
    }
}
