using System;
using System.Security.Cryptography;
using System.Text;

public class CallbackUrlSignatureValidation
{
    public static void Main()
    {
        // You can verify the request using the method below

        // For verification
        string secretKey = "merchant_secret_key";
        string conversationData = "conversationData_from_callbackUrl";
        string conversationId = "conversationId_from_callbackUrl";
        string mdStatus = "mdStatus_from_callbackUrl";
        string paymentId = "paymentId_from_callbackUrl";
        string status = "status_from_callbackUrl";

        string dataToSign = conversationData + ":" + conversationId + ":" + mdStatus + ":" + paymentId + ":" + status;
        string hmac256Signature = CalculateHMACSHA256(dataToSign, secretKey);

        string signature = "signature_from_callbackUrl_payload";

        if (hmac256Signature == signature)
        {
            Console.WriteLine("HMAC-SHA256 Signature Verified: " + hmac256Signature);
            Console.WriteLine("Enjoy your code...");
        }
        else
        {
            Console.WriteLine("Signature verification failed.");
        }

        /*
        * Sample Signature Calculation
        *
        * Payload: status=success&paymentId=22484292&conversationData=&conversationId=&mdStatus
        * =1&signature=a4f73b80bb32a6ef8358090bbd8609a49a7b53f463048f8ef147496e236d04f0
        * 
        * $secretKey = "jLc7GQHD2pyJoqXDeEcTnGHYtP7Ai5jl";
        * $conversationData = "";
        * $conversationId = "";
        * $mdStatus = "1";
        * $paymentId = "22484292";
        * $status = "success";
        *
        * $signature = "a4f73b80bb32a6ef8358090bbd8609a49a7b53f463048f8ef147496e236d04f0";
        *
        * $dataToSign = "::1:22484292:success";
        *
        * After hashing string with secretKey
        * $hmac256Signature = "a4f73b80bb32a6ef8358090bbd8609a49a7b53f463048f8ef147496e236d04f0";
        *
        * $hmac256Signature is equal to $signature so the request validated.
        */
    }

    private static string CalculateHMACSHA256(string data, string key)
    {
        byte[] keyBytes = Encoding.UTF8.GetBytes(key);
        byte[] dataBytes = Encoding.UTF8.GetBytes(data);

        using (var hmac = new HMACSHA256(keyBytes))
        {
            byte[] hmacBytes = hmac.ComputeHash(dataBytes);
            return BitConverter.ToString(hmacBytes).Replace("-", "").ToLower();
        }
    }
}
