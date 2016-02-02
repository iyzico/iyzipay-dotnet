using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    class CrossBookingFromSubMerchant : IyzipayResource
    {
        public static CrossBookingFromSubMerchant Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().Post<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", GetHttpHeaders(request, options), request);
        }
    }
}
