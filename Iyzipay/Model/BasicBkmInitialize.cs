using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
    public class BasicBkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }
        
        public static BasicBkmInitialize Create(CreateBasicBkmInitializeRequest request, Options options)
        {
            BasicBkmInitialize response = RestHttpClient.Create().Post<BasicBkmInitialize>(options.BaseUrl + "/payment/bkm/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
