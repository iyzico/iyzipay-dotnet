using System;
using System.Security.Cryptography;
using System.Text;

public class WebhookSignatureValidation
{
    public static void Main()
    {
        // For CO Form and Pay with iyzico
        string secretKey = "merchant_secret_key";
        string iyziEventType = "iyziEventType_from_webhook_payload";
        string iyziPaymentId = "iyziPaymentId_from_webhook_payload";
        string token = "token_from_webhook_payload";
        string paymentConversationId = "paymentConversationId_from_webhook_payload";
        string status = "status_from_webhook_payload";

        string key = secretKey + iyziEventType + iyziPaymentId + token + paymentConversationId + status;
        string hmac256Signature = CalculateHMACSHA256(key, secretKey);

        string signature_v3 = "signature_v3_from_webhook_header";

        if (hmac256Signature == signature_v3)
        {
            Console.WriteLine("HMAC-SHA256 Signature Verified: " + hmac256Signature);
            Console.WriteLine("Enjoy your code...");
        }
        else
        {
            Console.WriteLine("Signature verification failed.");
        }

        // For Direct Payments via API
        secretKey = "merchant_secret_key";
        iyziEventType = "iyziEventType_from_webhook_payload";
        string paymentId = "iyziPaymentId_from_webhook_payload";
        paymentConversationId = "paymentConversationId_from_webhook_payload";
        status = "status_from_webhook_payload";

        key = secretKey + iyziEventType + paymentId + paymentConversationId + status;
        hmac256Signature = CalculateHMACSHA256(key, secretKey);

        signature_v3 = "signature_v3_from_webhook_header";

        if (hmac256Signature == signature_v3)
        {
            Console.WriteLine("HMAC-SHA256 Signature Verified: " + hmac256Signature);
            Console.WriteLine("Enjoy your code...");
        }
        else
        {
            Console.WriteLine("Signature verification failed.");
        }
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
