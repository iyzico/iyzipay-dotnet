using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicBkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }

        private const string CreateUrl = "payment/bkm/initialize/basic";
        public async static Task<BasicBkmInitialize> CreateAsync(CreateBasicBkmInitializeRequest request, Options options)
        {
            BasicBkmInitialize response = await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicBkmInitialize>(CreateUrl, GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public static BasicBkmInitialize Create(CreateBasicBkmInitializeRequest request, Options options)
        {
            BasicBkmInitialize response = RestHttpClient.Create(options.BaseUrl).Post<BasicBkmInitialize>(CreateUrl, GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
