﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using Newtonsoft.Json.Serialization;
using Newtonsoft.Json;

namespace Iyzipay
{
    public class IyzipayResourceV2
    {
        private static readonly string AUTHORIZATION = "Authorization";
        private static readonly string AUTHORIZATION_FALLBACK_HEADER = "AUTHORIZATION_FALLBACK_HEADER";
        private static readonly string CONVERSATION_ID_HEADER_NAME = "x-conversation-id";
        private static readonly string CLIENT_VERSION_HEADER_NAME = "x-iyzi-client-version";
        private static readonly string IYZIWS_V2_HEADER_NAME = "IYZWSv2 ";
        private static readonly string IYZIWS_HEADER_NAME = "IYZWS ";
        private static readonly string COLON = ":";

        public String Status { get; set; }
        public int StatusCode { get; set; }
        public String ErrorCode { get; set; }
        public String ErrorMessage { get; set; }
        public String ErrorGroup { get; set; }
        public String ConversationId { get; set; }
        public long SystemTime { get; set; }
        public String Locale { get; set; }

        public IyzipayResourceV2()
        {
        }

        public void AppendWithHttpResponseHeaders(HttpResponseMessage httpResponseMessage)
        {
            HttpHeaders responseHeaders = httpResponseMessage.Headers;
            this.StatusCode = Convert.ToInt32(httpResponseMessage.StatusCode);

            IEnumerable<string> values;
            if (responseHeaders.TryGetValues(CONVERSATION_ID_HEADER_NAME, out values))
            {
                string conversationId = values.First();
                this.ConversationId = !string.IsNullOrWhiteSpace(conversationId) ? conversationId : null;
            }
        }

        protected static Dictionary<string, string> GetHttpHeadersWithRequestBody(BaseRequestV2 request, String url,  Options options)
        {
            Dictionary<string, string> headers = GetCommonHttpHeaders(request, url, options);
            headers.Add(AUTHORIZATION, PrepareAuthorizationStringWithRequestBody(request, url, options));
            headers.Add(AUTHORIZATION_FALLBACK_HEADER, PrepareAuthorizationString(request, url, options));
            return headers;
        }

        protected static Dictionary<string, string> GetHttpHeadersWithUrlParams(BaseRequestV2 request, String url, Options options)
        {
            Dictionary<string, string> headers = GetCommonHttpHeaders(request, url, options);
            headers.Add(AUTHORIZATION, PrepareAuthorizationStringWithRequestBody(null, url, options));
            return headers;
        }

        private static Dictionary<string, string> GetCommonHttpHeaders(BaseRequestV2 request, String url, Options options)
        {
            Dictionary<string, string> headers = new Dictionary<string, string>();
            headers.Add("Accept", "application/json");
            headers.Add(CLIENT_VERSION_HEADER_NAME, IyzipayConstants.CLIENT_VERSION);
            headers.Add(CONVERSATION_ID_HEADER_NAME, request.ConversationId);
            return headers;
        }

        private static String PrepareAuthorizationStringWithRequestBody(BaseRequestV2 request, String url, Options options)
        {
            String randomKey = GenerateRandomKey();
            String uriPath = FindUriPath(url);
            var settings = new JsonSerializerSettings
            {
                ContractResolver = new CamelCasePropertyNamesContractResolver(),
            };
            String payload = request != null ? uriPath + JsonConvert.SerializeObject(request, settings) : uriPath;
            String dataToEncrypt = randomKey + payload;
            String hash = HashGeneratorV2.GenerateHash(options.ApiKey, options.SecretKey, randomKey, dataToEncrypt); 
            return IYZIWS_V2_HEADER_NAME + hash;
        }

        private static String PrepareAuthorizationStringWithUrlParam(BaseRequestV2 request, String url, Options options)
        {
            String randomKey = GenerateRandomKey();
            String uriPath = FindUriPath(url);
            String dataToEncrypt = randomKey + uriPath;

            String hash = HashGeneratorV2.GenerateHash(options.ApiKey, options.SecretKey, randomKey, dataToEncrypt);
            return IYZIWS_V2_HEADER_NAME + hash;
        }
        private static string PrepareAuthorizationString(BaseRequestV2 request, string randomString, Options options)
        {
            string hash = HashGenerator.GenerateHash(options.ApiKey, options.SecretKey, randomString, request);
            return IYZIWS_HEADER_NAME + options.ApiKey + COLON + hash;
        }
        private static String GenerateRandomKey()
        {
            return DateTime.Now.ToString("ddMMyyyyhhmmssffff");
        }

        private static String FindUriPath(String url)
        {
            int startIndex = url.IndexOf("/v2");
            if (startIndex == -1)
            {
                startIndex = url.IndexOf(".com")+4;
            }
            int endIndex = url.IndexOf("?");
            int length = endIndex == -1 ? url.Length - startIndex : endIndex - startIndex;
            return url.Substring(startIndex, length);
        }
    }
}
