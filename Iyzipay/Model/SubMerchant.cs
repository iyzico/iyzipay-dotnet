﻿using Iyzipay.Request;
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

        public static Task<SubMerchant> Create(CreateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<SubMerchant>(options.BaseUrl + "/onboarding/submerchant", GetHttpHeaders(request, options), request);
        }

        public static Task<SubMerchant> Update(UpdateSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().PutAsync<SubMerchant>(options.BaseUrl + "/onboarding/submerchant", GetHttpHeaders(request, options), request);
        }

        public static Task<SubMerchant> Retrieve(RetrieveSubMerchantRequest request, Options options)
        {
            return RestHttpClient.Create().PostAsync<SubMerchant>(options.BaseUrl + "/onboarding/submerchant/detail", GetHttpHeaders(request, options), request);
        }
    }
}
