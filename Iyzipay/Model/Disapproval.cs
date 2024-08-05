using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class Disapproval : IyzipayResourceV2
	{
		public string PaymentTransactionId { get; set; }

		public static Task<Disapproval> Create(CreateApprovalRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/iyzipos/item/disapprove";
			return RestHttpClientV2.Create().PostAsync<Disapproval>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
