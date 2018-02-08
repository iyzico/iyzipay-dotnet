using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingToSubMerchant : IyzipayResource
    {
        public async static Task<CrossBookingToSubMerchant> CreateAsync(CreateCrossBookingRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<CrossBookingToSubMerchant>("crossbooking/send", GetHttpHeaders(request, options), request);
        }

        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<CrossBookingToSubMerchant>("crossbooking/send", GetHttpHeaders(request, options), request);
        }
    }
}
