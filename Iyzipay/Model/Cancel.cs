using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class Cancel : IyzipayResourceV2
	{
		public string PaymentId { get; set; }
		public string Price { get; set; }
		public string Currency { get; set; }
		public string ConnectorName { get; set; }
		public string AuthCode { get; set; }
		public string HostReference { get; set; }

		public static Task<Cancel> Create(CreateCancelRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/cancel";

			return RestHttpClient.Create().PostAsync<Cancel>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
