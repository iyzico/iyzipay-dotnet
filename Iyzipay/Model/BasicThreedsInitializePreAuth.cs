using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BasicThreedsInitializePreAuth : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public string HtmlContent { get; set; }

		public static async Task<BasicThreedsInitializePreAuth> Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/initialize/preauth/basic";
			BasicThreedsInitializePreAuth response = await RestHttpClientV2.Create().PostAsync<BasicThreedsInitializePreAuth>(options.BaseUrl + uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
