using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BKMInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }

        public static BKMInitialize Create(CreateBKMInitializeRequest request, Options options)
        {
            return RestHttpClient.Create().Post<BKMInitialize>(options.BaseUrl + "/payment/iyzipos/bkm/initialize/ecom", GetHttpHeaders(request, options), request);
        }
    }
}
