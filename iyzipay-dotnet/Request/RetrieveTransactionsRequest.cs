using System;

namespace Iyzipay.Request
{
    public class RetrieveTransactionsRequest: BaseRequest
    {
        public String Date { get; set; }

        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("date", Date)
                .GetRequestString();
        }
    }
}
