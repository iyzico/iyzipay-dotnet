using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class PaymentItem : IyzipayResourceV2
	{
		public string ItemId { get; set; }
		public string PaymentTransactionId { get; set; }
		public int? TransactionStatus { get; set; }
		public string Price { get; set; }
		public string PaidPrice { get; set; }
		public string MerchantCommissionRate { get; set; }
		public string MerchantCommissionRateAmount { get; set; }
		public string IyziCommissionRateAmount { get; set; }
		public string IyziCommissionFee { get; set; }
		public string BlockageRate { get; set; }
		public string BlockageRateAmountMerchant { get; set; }
		public string BlockageRateAmountSubMerchant { get; set; }
		public string BlockageResolvedDate { get; set; }
		public string SubMerchantKey { get; set; }
		public string SubMerchantPrice { get; set; }
		public string SubMerchantPayoutRate { get; set; }
		public string SubMerchantPayoutAmount { get; set; }
		public string MerchantPayoutAmount { get; set; }
		public ConvertedPayout ConvertedPayout { get; set; }
		public string WithholdingTax { get; set; }

		public static Task<PaymentItem> Update(UpdatePaymentItemRequest request, Options options)
		{
			var uri = options.BaseUrl + "/payment/item";
			return RestHttpClientV2.Create().PutAsync<PaymentItem>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
