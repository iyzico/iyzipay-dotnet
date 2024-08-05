using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class CrossBookingFromSubMerchant : IyzipayResourceV2
	{
		public static Task<CrossBookingFromSubMerchant> Create(CreateCrossBookingRequest request, Options options)
		{
			var uri = options.BaseUrl + "/crossbooking/receive";
			return RestHttpClientV2.Create().PostAsync<CrossBookingFromSubMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
