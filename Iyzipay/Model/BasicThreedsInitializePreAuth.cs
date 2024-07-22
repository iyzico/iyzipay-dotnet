using Iyzipay.Request;
using System;
using Newtonsoft.Json;

namespace Iyzipay.Model
{
	public class BasicThreedsInitializePreAuth : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public String HtmlContent { get; set; }

		public static BasicThreedsInitializePreAuth Create(CreateBasicPaymentRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/3dsecure/initialize/preauth/basic";
			BasicThreedsInitializePreAuth response = RestHttpClientV2.Create().Post<BasicThreedsInitializePreAuth>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
