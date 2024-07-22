using System;
using System.Security.Cryptography;
using System.Text;

namespace Iyzipay.Samples
{
	public class SignatureVerification
	{
		public static string CalculateHmacSHA256Signature(string secretKey, string[] parameters)
		{
			string dataToSign = string.Join(":", parameters);
			byte[] keyBytes = Encoding.UTF8.GetBytes(secretKey);
			byte[] dataBytes = Encoding.UTF8.GetBytes(dataToSign);

			using (var hmac = new HMACSHA256(keyBytes))
			{
				byte[] hashBytes = hmac.ComputeHash(dataBytes);
				return BitConverter.ToString(hashBytes).Replace("-", "").ToLower();
			}
		}
	}
}
