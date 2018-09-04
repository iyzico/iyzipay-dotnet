using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace Iyzipay
{
    public class HashGeneratorV2
    {
        private HashGeneratorV2()
        {
        }

        public static String GenerateHash(String apiKey, String secretKey, String randomString, String dataToEncrypt)
        {
            HashAlgorithm algorithm = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey));
            byte[] computedHash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(dataToEncrypt));
            String computedHashAsHex = BitConverter.ToString(computedHash).Replace("-", "").ToLower();
            String authorizationString = "apiKey:" + apiKey + "&randomKey:" + randomString + "&signature:" + computedHashAsHex;
            return Convert.ToBase64String(Encoding.UTF8.GetBytes(authorizationString));
        }
    }
}
