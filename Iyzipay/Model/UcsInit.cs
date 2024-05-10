using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class UcsInit : IyzipayResourceV2
	{
		public string UcsToken { get; set; }
		public string BuyerProtectedConsumer { get; set; }
		public string BuyerProtectedMerchant { get; set; }
		public string GsmNumber { get; set; }
		public string MaskedGsmNumber { get; set; }
		public string MerchantName { get; set; }
		public string Script { get; set; }
		public string ScriptType { get; set; }

		public static UcsInit Create(InitUcsRequest request, Options options)
		{
			string uri = options.BaseUrl + "/v2/ucs/init";
			UcsInit response = RestHttpClientV2.Create().Post<UcsInit>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
			return response;
		}
	}
}
