using System;
using System.Security.Cryptography;
using System.Text;

namespace Iyzipay
{
    public sealed class HashGenerator
    {
        private HashGenerator()
        {
        }

        public static String GenerateHash(String apiKey, String secretKey, String randomString, BaseRequest request)
        {
            HashAlgorithm algorithm = new SHA1Managed();
            string hashStr = apiKey + randomString + secretKey + request.ToPKIRequestString();
            byte[] computeHash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(hashStr));
            return Convert.ToBase64String(computeHash);
        }
    }
}
