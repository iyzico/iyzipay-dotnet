using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class Cancel : IyzipayResource
    {
        public String PaymentId { get; set; }
        public decimal? Price { get; set; }

        public static Task<Cancel> Create(CreateCancelRequest request, Options options)
        {
            return new RestHttpClient().Post<Cancel>(options.BaseUrl + "/payment/iyzipos/cancel", GetHttpHeaders(request, options), request);
        }
    }
}
