using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class BKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static Approval Create(CreateBKMInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Approval>(options.BaseUrl + "/payment/iyzipos/bkm/initialize/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
