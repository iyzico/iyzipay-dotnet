using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Cancel : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String Price { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }
        public String AuthCode { get; set; }
        public String HostReference { get; set; }

        public static Task<Cancel> Create(CreateCancelRequest request, Options options)
		{
			return RestHttpClient.Create().PostAsync<Cancel>(options.BaseUrl + "/payment/cancel", GetHttpHeaders(request, options), request);
		}
    }
}
