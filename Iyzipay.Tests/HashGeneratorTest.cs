using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;

namespace Iyzipay.Tests
{
    public class HashGeneratorTest
    {
        [Test]
        public void Should_Generate_Hash()
        {
            string expectedHash = "Cy84UuLZpfGhI7oaPD0Ckx1M0mo=";
            string generatedHash = HashGenerator.GenerateHash("apiKey", "secretKey", "random", new TestRequest());

            Assert.AreEqual(expectedHash, generatedHash);
        }
    }

    public class TestRequest : BaseRequest
    {
        public override string ToPKIRequestString()
        {
            return "[data=value]";
        }
    }
}
