using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class CheckoutForm : PaymentResource
	{
		public string Token { get; set; }
		public string CallbackUrl { get; set; }

		public static Task<CheckoutForm> Retrieve(RetrieveCheckoutFormRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/checkoutform/auth/ecom/detail";

			return RestHttpClientV2.Create().PostAsync<CheckoutForm>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
