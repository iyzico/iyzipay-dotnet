using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

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

        [Test]
        public async Task Should_Test_ApiAsync()
        {
            IyzipayResource iyzipayResource = await ApiTest.RetrieveAsync(options);

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
