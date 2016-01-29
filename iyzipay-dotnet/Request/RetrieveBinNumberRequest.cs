using System;

namespace Iyzipay.Request
{
    class RetrieveBinNumberRequest : BaseRequest
    {
        public String BinNumber { get; set; }

        public  override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("binNumber", BinNumber)
                .GetRequestString();
        }
    }
}
