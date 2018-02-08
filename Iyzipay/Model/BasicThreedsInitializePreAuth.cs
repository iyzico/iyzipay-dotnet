﻿using Iyzipay.Request;
using System;
using Newtonsoft.Json;
using System.Threading.Tasks;

namespace Iyzipay.Model
{
    public class BasicThreedsInitializePreAuth : IyzipayResource
    {
        [JsonProperty(PropertyName = "threeDSHtmlContent")]
        public String HtmlContent { get; set; }

        public async static Task<BasicThreedsInitializePreAuth> CreateAsync(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitializePreAuth response = await RestHttpClient.Create(options.BaseUrl).PostAsync<BasicThreedsInitializePreAuth>("payment/3dsecure/initialize/preauth/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }

        public static BasicThreedsInitializePreAuth Create(CreateBasicPaymentRequest request, Options options)
        {
            BasicThreedsInitializePreAuth response = RestHttpClient.Create(options.BaseUrl).Post<BasicThreedsInitializePreAuth>("payment/3dsecure/initialize/preauth/basic", GetHttpHeaders(request, options), request);

            if (response != null)
            {
                response.HtmlContent = DigestHelper.DecodeString(response.HtmlContent);
            }
            return response;
        }
    }
}
