using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class CrossBookingToSubMerchant : IyzipayResourceV2
	{
		public static Task<CrossBookingToSubMerchant> Create(CreateCrossBookingRequest request, Options options)
		{
			var uri = options.BaseUrl + "/crossbooking/send";
			return RestHttpClientV2.Create().PostAsync<CrossBookingToSubMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
