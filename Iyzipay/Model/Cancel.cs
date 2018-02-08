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

        private const string CreateUrl = "payment/cancel";
        public async static Task<Cancel> CreateAsync(CreateCancelRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<Cancel>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static Cancel Create(CreateCancelRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<Cancel>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
