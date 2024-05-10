using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class ThreedsInitialize : IyzipayResource
	{
		[JsonProperty(PropertyName = "threeDSHtmlContent")]
		public String HtmlContent { get; set; }

		public static async Task<ThreedsInitialize> Create(CreatePaymentRequest request, Options options)
		{
			ThreedsInitialize response = await RestHttpClient.Create().PostAsync<ThreedsInitialize>(options.BaseUrl + "/payment/3dsecure/initialize", GetHttpHeaders(request, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
