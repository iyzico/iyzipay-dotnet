using System;
using System.Net;

namespace Iyzipay
{
    public class IyzipayResource
    {
        private static readonly String AUTHORIZATION = "Authorization";
        private static readonly String RANDOM_HEADER_NAME = "x-iyzi-rnd";
        private static readonly String CLIENT_VERSION = "x-iyzi-client-version";
        private static readonly String IYZIWS_HEADER_NAME = "IYZWS ";
        private static readonly String COLON = ":";

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

        protected static WebHeaderCollection GetHttpHeaders(BaseRequest request, Options options)
        {
            string randomString = DateTime.Now.ToString("ddMMyyyyhhmmssffff");
            WebHeaderCollection headers = new WebHeaderCollection();
            headers.Add("Accept", "application/json");
            headers.Add(RANDOM_HEADER_NAME, randomString);
            headers.Add(CLIENT_VERSION, "iyzipay-dotnet-2.1.14");
            headers.Add(AUTHORIZATION, PrepareAuthorizationString(request, randomString, options));
            return headers;
        }

        private static String PrepareAuthorizationString(BaseRequest request, String randomString, Options options)
        {
            String hash = HashGenerator.GenerateHash(options.ApiKey, options.SecretKey, randomString, request);
            return IYZIWS_HEADER_NAME + options.ApiKey + COLON + hash;
        }
    }
}
