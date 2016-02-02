using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingToSubMerchant : IyzipayResource
    {
        public static CrossBookingToSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingToSubMerchant>(options.BaseUrl + "/crossbooking/send", GetHttpHeaders(request, options), request);
        }
    }
}
