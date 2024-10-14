using Iyzipay.Request;
using Newtonsoft.Json;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class BinNumber : IyzipayResourceV2
	{
		[JsonProperty(PropertyName = "binNumber")]
		public String Bin { get; set; }
		public String CardType { get; set; }
		public String CardAssociation { get; set; }
		public String CardFamily { get; set; }
		public String BankName { get; set; }
		public long BankCode { get; set; }
		public int Commercial { get; set; }

		public static Task<BinNumber> Retrieve(RetrieveBinNumberRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/bin/check";
			return RestHttpClientV2.Create().PostAsync<BinNumber>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
