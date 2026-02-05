using System;
using NUnit.Framework;

namespace Iyzipay.Tests
{
    public class HashGeneratorV2Test
    {
        [Test]
        public void Should_Generate_Hash_With_HMAC_SHA256()
        {
            // Arrange
            string apiKey = "sandbox-apiKey";
            string secretKey = "sandbox-secretKey";
            string randomKey = "123456789";
            string dataToEncrypt = randomKey + "/payment/3dsecure/auth" + "{\"locale\":\"tr\",\"paymentId\":\"1\"}";

            // Act
            string generatedHash = HashGeneratorV2.GenerateHash(apiKey, secretKey, randomKey, dataToEncrypt);

            // Assert
            Assert.IsNotNull(generatedHash);
            Assert.IsNotEmpty(generatedHash);

            // Verify it's valid Base64
            byte[] decodedBytes = Convert.FromBase64String(generatedHash);
            string decodedString = System.Text.Encoding.UTF8.GetString(decodedBytes);

            // Verify the structure: apiKey:{apiKey}&randomKey:{randomKey}&signature:{hex}
            Assert.That(decodedString, Does.Contain("apiKey:" + apiKey));
            Assert.That(decodedString, Does.Contain("&randomKey:" + randomKey));
            Assert.That(decodedString, Does.Contain("&signature:"));
        }

        [Test]
        public void Should_Generate_Consistent_Hash_For_Same_Input()
        {
            // Arrange
            string apiKey = "testApiKey";
            string secretKey = "testSecretKey";
            string randomKey = "randomKey123";
            string dataToEncrypt = randomKey + "/v2/test/endpoint";

            // Act
            string hash1 = HashGeneratorV2.GenerateHash(apiKey, secretKey, randomKey, dataToEncrypt);
            string hash2 = HashGeneratorV2.GenerateHash(apiKey, secretKey, randomKey, dataToEncrypt);

            // Assert
            Assert.AreEqual(hash1, hash2);
        }

        [Test]
        public void Should_Generate_Different_Hash_For_Different_Secret()
        {
            // Arrange
            string apiKey = "testApiKey";
            string randomKey = "randomKey123";
            string dataToEncrypt = randomKey + "/v2/test/endpoint";

            // Act
            string hash1 = HashGeneratorV2.GenerateHash(apiKey, "secretKey1", randomKey, dataToEncrypt);
            string hash2 = HashGeneratorV2.GenerateHash(apiKey, "secretKey2", randomKey, dataToEncrypt);

            // Assert
            Assert.AreNotEqual(hash1, hash2);
        }
    }
}