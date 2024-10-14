using System;
using System.Security.Cryptography;
using System.Text;

public class SignatureGeneration
{
    public static void Main()
    {
        // Sample hash signature calculation for the /payment/auth endpoint response signature.
        // You can refer to https://docs.iyzico.com/v/en/advanced/response-signature-validation for other endpoints and signature parameters.
        string secretKey = "sandbox-qaIiLIxhjMgx3LSKIVvp6j17NunHOFtD";
        string[] parameters = {
            "22416032",   // paymentId
            "TRY",        // currency
            "basketId",	  // basketId
            "conversationId",  // conversationId
            "10.5",       // paidPrice
            "10.5"        // price
        };

        string hashedSignature = CalculateHMACSHA256(parameters, secretKey);

        Console.WriteLine("Generated Signature: " + hashedSignature);
    }

    // HashSignature
    private static string CalculateHMACSHA256(string[] data, string key)
    {
        string dataToEncrypt = string.Join(":", data);
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] dataBytes = Encoding.UTF8.GetBytes(dataToEncrypt);

        using (var hmac = new HMACSHA256(keyBytes))
        {
            byte[] hmacBytes = hmac.ComputeHash(dataBytes);
            return BitConverter.ToString(hmacBytes).Replace("-", "").ToLower();
        }
    }
}
