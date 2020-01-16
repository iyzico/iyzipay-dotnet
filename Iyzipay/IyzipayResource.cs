using System;
using System.Net;

namespace Iyzipay
{
    public class IyzipayResource
    {
        private static readonly String AUTHORIZATION = "Authorization";
        private static readonly String RANDOM_HEADER_NAME = "x-iyzi-rnd";
        private static readonly String CLIENT_VERSION_HEADER_NAME = "x-iyzi-client-version";
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

#if NETSTANDARD
            headers["Accept"] = "application/json";
            headers[RANDOM_HEADER_NAME] = randomString;
            headers[CLIENT_VERSION] = "iyzipay-dotnet-2.1.14";
            headers[AUTHORIZATION] = PrepareAuthorizationString(request, randomString, options);
#else
            headers.Add("Accept", "application/json");
            headers.Add(RANDOM_HEADER_NAME, randomString);
            headers.Add(CLIENT_VERSION_HEADER_NAME, IyzipayConstants.CLIENT_VERSION);
            headers.Add(AUTHORIZATION, PrepareAuthorizationString(request, randomString, options));
#endif
            return headers;
        }

        private static string PrepareAuthorizationString(BaseRequest request, string randomString, Options options)
        {
            string hash = HashGenerator.GenerateHash(options.ApiKey, options.SecretKey, randomString, request);
            return IYZIWS_HEADER_NAME + options.ApiKey + COLON + hash;
        }
    }
}
