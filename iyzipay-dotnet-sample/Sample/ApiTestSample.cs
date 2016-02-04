using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay;
using Iyzipay.Model;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ApiTestSample : Sample
    {
        [TestMethod]
        public void Should_Test_Api()
        {
            IyzipayResource iyzipayResource = ApiTest.Retrieve(options);

            PrintResponse<IyzipayResource>(iyzipayResource);

            Assert.IsNotNull(iyzipayResource.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), iyzipayResource.Status);
        }
    }
}
