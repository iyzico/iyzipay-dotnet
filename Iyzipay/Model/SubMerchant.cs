using Iyzipay.Request;
using System;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class SubMerchant : IyzipayResource
    {
        public String Name { get; set; }
        public String Email { get; set; }
        public String GsmNumber { get; set; }
        public String Address { get; set; }
        public String Iban { get; set; }
        public String SwiftCode { get; set; }
        public String Currency { get; set; }
        public String TaxOffice { get; set; }
        public String ContactName { get; set; }
        public String ContactSurname { get; set; }
        public String LegalCompanyTitle { get; set; }
        public String SubMerchantExternalId { get; set; }
        public String IdentityNumber { get; set; }
        public String TaxNumber { get; set; }
        public String SubMerchantType { get; set; }
        public String SubMerchantKey { get; set; }
        public String SettlementDescriptionTemplate { get; set; }

        private const string CreateUrl = "onboarding/submerchant";
        private const string UpdateUrl = "onboarding/submerchant";
        private const string RetreiveUrl = "onboarding/submerchant/detail";
        public static SubMerchant Create(CreateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<SubMerchant>(CreateUrl, GetHttpHeaders(request, options), request);
        }

        public static SubMerchant Update(UpdateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Put<SubMerchant>(UpdateUrl, GetHttpHeaders(request, options), request);
        }

        public static SubMerchant Retrieve(RetrieveSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create(options.BaseUrl).Post<SubMerchant>(RetreiveUrl, GetHttpHeaders(request, options), request);
        }


        public async static Task<SubMerchant> CreateAsync(CreateSubMerchantRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<SubMerchant>(CreateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public async static Task<SubMerchant> UpdateAsync(UpdateSubMerchantRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PutAsync<SubMerchant>(UpdateUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }

        public async static Task<SubMerchant> RetrieveAsync(RetrieveSubMerchantRequest request, Options options)
        {
            return await RestHttpClient.Create(options.BaseUrl).PostAsync<SubMerchant>(RetreiveUrl, GetHttpHeaders(request, options), request).ConfigureAwait(false);
        }
    }
}
