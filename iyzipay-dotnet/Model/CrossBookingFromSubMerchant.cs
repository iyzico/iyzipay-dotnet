using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingFromSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingFromSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            PrepareHttpClientWithHeaders(request, options);
            return new BaseHttpClient().Post<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", request);
        }
    }
}
