using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class BKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static Task<Approval> Create(CreateBKMInitializeRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<Approval>(options.BaseUrl + "/payment/iyzipos/bkm/initialize/ecom", request);
        }
    }
}
