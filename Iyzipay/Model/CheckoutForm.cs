using Iyzipay.Request;
using System;

namespace Iyzipay.Model
{
	public class CheckoutForm : PaymentResource
	{
		public string Token { get; set; }
		public string CallbackUrl { get; set; }

		public static CheckoutForm Retrieve(RetrieveCheckoutFormRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail";
			return RestHttpClientV2.Create().Post<CheckoutForm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
