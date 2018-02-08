using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class Refund : IyzipayResource
    {
        public String PaymentId { get; set; }
        public String PaymentTransactionId { get; set; }
        public String Price { get; set; }
        public String Currency { get; set; }
        public String ConnectorName { get; set; }

        private const string CreateUrl = "payment/refund";
        public static Refund Create(CreateRefundRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Refund>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public async static Task<Refund> CreateAsync(CreateRefundRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Refund>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }
    }
}
