using System;
using Iyzipay.Model;
using Newtonsoft.Json;

namespace Iyzipay.Request
{
	public class IyziLinkSaveRequest : BaseRequestV2
	{
		public string Name { get; set; }
		public string Description { get; set; }
		[JsonProperty(PropertyName = "encodedImageFile")]
		public string Base64EncodedImage { get; set; }
		public string Price { get; set; }
		[JsonProperty(PropertyName = "currencyCode")]
		public string Currency { get; set; }
		public bool? AddressIgnorable { get; set; }

		public bool StockEnabled { get; set; }
		public int StockCount { get; set; }
		public string SourceType { get; set; }
		public bool? InstallmentRequested { get; set; }
        public ProductBuyerInfo ProductBuyerInfo { get; set; }

    }
}