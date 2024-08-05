using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicBkmInitialize : IyzipayResourceV2
	{
		public string HtmlContent { get; set; }
		public string Token { get; set; }

		public static async Task<BasicBkmInitialize> Create(CreateBasicBkmInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/bkm/initialize/basic";
			BasicBkmInitialize response = await RestHttpClientV2.Create().PostAsync<BasicBkmInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
