using System.Collections.Generic;
using Newtonsoft.Json;
using Iyzipay.Request;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BouncedBankTransferList : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "bouncedRows")]
		public List<BankTransfer> BankTransfers { get; set; }

		public static Task<BouncedBankTransferList> Retrieve(RetrieveTransactionsRequest request, Options options)
		{
			var uri = options.BaseUrl + "/reporting/settlement/bounced";
			return RestHttpClientV2.Create().PostAsync<BouncedBankTransferList>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
