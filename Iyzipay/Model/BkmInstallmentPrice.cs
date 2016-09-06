using System;

namespace Iyzipay.Model
{
  public  class BkmInstallmentPrice : RequestStringConvertible
    {
        public int? InstallmentNumber { get; set; }
        public String TotalPrice { get; set; }

        public String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("installmentNumber", InstallmentNumber)
                .AppendPrice("totalPrice", TotalPrice)
                .GetRequestString();
        }
    }
}
