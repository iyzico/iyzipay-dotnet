using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
	public class ThreedsInitialize : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public String HtmlContent { get; set; }

		public static ThreedsInitialize Create(CreatePaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/initialize";
			ThreedsInitialize response = RestHttpClientV2.Create().Post<ThreedsInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
