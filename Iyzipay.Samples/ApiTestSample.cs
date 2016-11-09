using Iyzipay.Model;
using NUnit.Framework;

namespace Iyzipay.Samples
{
    public class ApiTestSample : Sample
    {
        [Test]
        public void Should_Test_Api()
        {
            IyzipayResource iyzipayResource = ApiTest.Retrieve(options);

            PrintResponse<IyzipayResource>(iyzipayResource);

            Assert.AreEqual(Status.SUCCESS.ToString(), iyzipayResource.Status);
            Assert.AreEqual(Locale.TR.ToString(), iyzipayResource.Locale);
            Assert.IsNotNull(iyzipayResource.SystemTime);
            Assert.IsNull(iyzipayResource.ErrorCode);
            Assert.IsNull(iyzipayResource.ErrorMessage);
            Assert.IsNull(iyzipayResource.ErrorGroup);
        }
    }
}
