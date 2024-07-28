using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class ThreedsInitializePreAuth : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public string HtmlContent { get; set; }

        public static async Task<ThreedsInitializePreAuth> Create(CreatePaymentRequest request, Options options)
        {
			var uri = options.BaseUrl + "/payment/3dsecure/initialize/preauth";
			ThreedsInitializePreAuth response = await RestHttpClientV2.Create().PostAsync<ThreedsInitializePreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
