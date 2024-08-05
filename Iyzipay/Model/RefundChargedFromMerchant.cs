using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class RefundChargedFromMerchant : IyzipayResourceV2
	{
		public string PaymentId { get; set; }
		public string PaymentTransactionId { get; set; }
		public string Price { get; set; }
		public string AuthCode { get; set; }
		public string HostReference { get; set; }

		public static Task<RefundChargedFromMerchant> Create(CreateRefundRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/refund/merchant/charge";
			return RestHttpClientV2.Create().PostAsync<RefundChargedFromMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
