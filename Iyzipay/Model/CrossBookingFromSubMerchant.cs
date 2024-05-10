using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class CrossBookingFromSubMerchant : IyzipayResource
    {
        public static Task<CrossBookingFromSubMerchant> Create(CreateCrossBookingRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<CrossBookingFromSubMerchant>(options.BaseUrl + "/crossbooking/receive", GetHttpHeaders(request, options), request);
        }
    }
}
