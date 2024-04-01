using System;
using Newtonsoft.Json;

namespace Iyzipay.Request
{
	public class IyziFastLinkSaveRequest : BaseRequestV2
	{
		public string Description { get; set; }
		public string Price { get; set; }
		[JsonProperty(PropertyName = "currencyCode")]
		public string Currency { get; set; }
		public string SourceType { get; set; }
	}
}