using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BkmInitialize : IyzipayResourceV2
	{
        public string HtmlContent { get; set; }
        public string Token { get; set; }
        
        public static async Task<BkmInitialize> Create(CreateBkmInitializeRequest request, Options options)
        {
			var uri = options.BaseUrl + "/payment/bkm/initialize";
			BkmInitialize response = await RestHttpClientV2.Create().PostAsync<BkmInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
