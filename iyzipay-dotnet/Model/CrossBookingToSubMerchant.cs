using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingToSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingToSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", request);
        }
    }
}
