using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
	public class BkmInitialize : IyzipayResourceV2
	{
		public string HtmlContent { get; set; }
		public string Token { get; set; }

		public static BkmInitialize Create(CreateBkmInitializeRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/bkm/initialize";
			BkmInitialize response = RestHttpClientV2.Create().Post<BkmInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);

			if (response != null)
			{
				response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
			}
			return response;
		}
	}
}
