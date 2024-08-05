using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
	public class SubMerchant : IyzipayResourceV2
	{
		public string Name { get; set; }
		public string Email { get; set; }
		public string GsmNumber { get; set; }
		public string Address { get; set; }
		public string Iban { get; set; }
		public string SwiftCode { get; set; }
		public string Currency { get; set; }
		public string TaxOffice { get; set; }
		public string ContactName { get; set; }
		public string ContactSurname { get; set; }
		public string LegalCompanyTitle { get; set; }
		public string SubMerchantExternalId { get; set; }
		public string IdentityNumber { get; set; }
		public string TaxNumber { get; set; }
		public string SubMerchantType { get; set; }
		public string SubMerchantKey { get; set; }
		public string SettlementDescriptionTemplate { get; set; }

		public static Task<SubMerchant> Create(CreateSubMerchantRequest request, Options options)
		{
			var uri = options.BaseUrl + "/onboarding/submerchant";
			return RestHttpClientV2.Create().PostAsync<SubMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Task<SubMerchant> Update(UpdateSubMerchantRequest request, Options options)
		{
			var uri = options.BaseUrl + "/onboarding/submerchant";
			return RestHttpClientV2.Create().PutAsync<SubMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}

		public static Task<SubMerchant> Retrieve(RetrieveSubMerchantRequest request, Options options)
		{
			var uri = options.BaseUrl + "/onboarding/submerchant/detail";
			return RestHttpClientV2.Create().PostAsync<SubMerchant>(uri, GetHttpHeadersWithRequestBody(request, uri, options), request);
		}
	}
}
