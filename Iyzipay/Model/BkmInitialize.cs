using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }

        private const string CreateUrl = "payment/bkm/initialize";
        public async static Task<BkmInitialize> CreateAsync(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = await RestHttpClient.Create(options.BaseUrl).PostAsync<BkmInitialize>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = RestHttpClient.Create(options.BaseUrl).Post<BkmInitialize>(CreateUrl, GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
