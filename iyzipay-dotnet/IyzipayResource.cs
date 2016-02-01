using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Cryptography;
using System.Text;

namespace Iyzipay
{
    public class IyzipayResource
    {
        private static readonly String AUTHORIZATION = "Authorization";
        private static readonly String RANDOM_HEADER_NAME = "x-iyzi-rnd";
        private static readonly String IYZIWS_HEADER_NAME = "IYZWS ";
        private static readonly String COLON = ":";
        private static readonly int RANDOM_STRING_SIZE = 8;

        public String Status { get; set; }
        public String ErrorCode { get; set; }
        public String ErrorMessage { get; set; }
        public String ErrorGroup { get; set; }
        public String Locale { get; set; }
        public long SystemTime { get; set; }
        public String ConversationId { get; set; }

        public IyzipayResource()
        {
        }

        protected static void PrepareHttpClientWithHeaders(BaseRequest request, Options options)
        {
            HttpClient httpClient = new HttpClient();
            string randomHeaderValue = DateTime.Now.ToLongTimeString();
            httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
            httpClient.DefaultRequestHeaders.Add(RANDOM_HEADER_NAME, randomHeaderValue);
            httpClient.DefaultRequestHeaders.Add(AUTHORIZATION, PrepareAuthorizationString(request, randomHeaderValue, options));
        }

        private static String PrepareAuthorizationString(BaseRequest request, String randomHeaderValue, Options options)
        {
            return IYZIWS_HEADER_NAME + options.ApiKey + COLON + HashGenerator.generateHash(options.ApiKey, options.SecretKey, randomHeaderValue, request);
        }
    }
}
