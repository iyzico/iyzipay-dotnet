using Iyzipay;
using Iyzipay.Model;
using NUnit.Framework;

namespace IyzipaySample.Sample
{
    public class ApiTestSample : Sample
    {
        [Test]
        public void Should_Test_Api()
        {
            IyzipayResource iyzipayResource = ApiTest.Retrieve(options);

            PrintResponse<IyzipayResource>(iyzipayResource);

            Assert.IsNotNull(iyzipayResource.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), iyzipayResource.Status);
        }
    }
}
