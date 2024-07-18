using System;
using System.Security.Cryptography;
using System.Text;

namespace Iyzipay.Samples
{
	public class SignatureVerification
	{
		public static string GenerateHash(string apiKey, string secretKey, string randomString, string dataToEncrypt)
		{
			HashAlgorithm algorithm = new HMACSHA256(Encoding.UTF8.GetBytes(secretKey));
			byte[] computedHash = algorithm.ComputeHash(Encoding.UTF8.GetBytes(dataToEncrypt));
			string computedHashAsHex = BitConverter.ToString(computedHash).Replace("-", "").ToLower();
			string authorizationString = "apiKey:" + apiKey + "&randomKey:" + randomString + "&signature:" + computedHashAsHex;
			return Convert.ToBase64String(Encoding.UTF8.GetBytes(authorizationString));
		}
	}
}
