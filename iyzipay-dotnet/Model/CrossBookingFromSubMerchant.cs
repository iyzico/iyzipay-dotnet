using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingFromSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingFromSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            return new RestHttpClient().Post<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", GetHttpHeaders(request, options), request);
        }
    }
}
