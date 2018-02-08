using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingFromSubMerchant : IyzipayResource
    {
        private const string CreateUrl = "crossbooking/receive";
        public async static Task<CrossBookingFromSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CrossBookingFromSubMerchant>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public static CrossBookingFromSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CrossBookingFromSubMerchant>(CreateUrl, GetHttpHeaders(request, options), request);
        }
    }
}
