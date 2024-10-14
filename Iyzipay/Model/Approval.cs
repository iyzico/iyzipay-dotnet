using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class Approval : IyzipayResourceV2
	{
		public string PaymentTransactionId { get; set; }

		public static Task<Approval> Create(CreateApprovalRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/item/approve";
			return RestHttpClientV2.Create().PostAsync<Approval>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
