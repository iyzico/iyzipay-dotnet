using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BkmInitialize : IyzipayResource
    {
        public String HtmlContent { get; set; }
        public String Token { get; set; }
        
        public async static Task<BkmInitialize> CreateAsync(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = await RestHttpClient.Create(options.BaseUrl).PostAsync<BkmInitialize>("payment/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
        {
            BkmInitialize response = RestHttpClient.Create(options.BaseUrl).Post<BkmInitialize>("payment/bkm/initialize", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
