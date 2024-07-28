using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicThreedsInitialize : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public string HtmlContent { get; set; }
		public static async Task<BasicThreedsInitialize> Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/initialize/basic";
			BasicThreedsInitialize response = await RestHttpClientV2.Create().PostAsync<BasicThreedsInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
