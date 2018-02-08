using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        private const string CreateUrl = "crossbooking/send";
        public async static Task<CrossBookingToSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CrossBookingToSubMerchant>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CrossBookingToSubMerchant>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
