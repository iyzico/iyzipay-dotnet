using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingFromSubMerchant : IyzipayResource
    {
        public async static Task<CrossBookingFromSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CrossBookingFromSubMerchant>("crossbooking/receive", GetHttpHeaders(request, options), request);
        }

        public static CrossBookingFromSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CrossBookingFromSubMerchant>("crossbooking/receive", GetHttpHeaders(request, options), request);
        }
    }
}
