using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class Cancel : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }

        public static Cancel Create(CreateCancelRequest request, Options options)
        {
            return RestHttpClient.Create().Post<Cancel>(options.BaseUrl + "/payment/iyzipos/cancel", GetHttpHeaders(request, options), request);
        }
    }
}
