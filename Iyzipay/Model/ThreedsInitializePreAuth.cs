using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
	public class ThreedsInitializePreAuth : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public String HtmlContent { get; set; }

		public static ThreedsInitializePreAuth Create(CreatePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/initialize/preauth";
			ThreedsInitializePreAuth response = RestHttpClientV2.Create().Post<ThreedsInitializePreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
