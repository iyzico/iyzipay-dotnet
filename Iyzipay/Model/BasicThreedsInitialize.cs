using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsInitialize : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public async static Task<BasicThreedsInitialize> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitialize response = await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicThreedsInitialize>("payment/3dsecure/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public static BasicThreedsInitialize Create(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitialize response = RestHttpClient.Create(options.BaseUrl).Post<BasicThreedsInitialize>("payment/3dsecure/initialize/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
