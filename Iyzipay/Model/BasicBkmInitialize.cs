using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicBkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }
        
        public static async Task<BasicBkmInitialize> Create(CreateBasicBkmInitializeRequest request, Options options)
        {
            BasicBkmInitialize response = await RestHttpClient.Create().PostAsync<BasicBkmInitialize>(options.BaseUrl + "/payment/bkm/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
