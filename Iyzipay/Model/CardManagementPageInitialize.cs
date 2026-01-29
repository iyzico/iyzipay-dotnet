using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class CardManagementPageInitialize : IyzipayResourceV2
	{
		public string ExternalId { get; set; }
		public string Token { get; set; }
		public string CardPageUrl { get; set; }

		public static CardManagementPageInitialize Create(CreateCardManagementPageInitializeRequest request, Options options)
		{
			var uri = $"{options.BaseUrl}/v1/card-management/pages";
			return RestHttpClientV2.Create().Post<CardManagementPageInitialize>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}

}