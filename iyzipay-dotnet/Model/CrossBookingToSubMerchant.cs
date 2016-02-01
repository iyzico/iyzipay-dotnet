using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingToSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingToSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            return new RestHttpClient().Post<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", GetHttpHeaders(request, options), request);
        }
    }
}
