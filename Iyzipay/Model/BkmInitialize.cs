using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class BkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }
        
        public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = RestHttpClient.Create().Post<BkmInitialize>(options.BaseUrl + "/payment/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
