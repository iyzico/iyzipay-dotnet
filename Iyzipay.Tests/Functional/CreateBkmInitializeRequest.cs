using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;

namespace Iyzipay.Tests.Functional
{
    public class BkmTest : BaseTest
    {
        [Test]
        public void Should_Initialize_Bkm()
        {
            CreateBkmInitializeRequest request = CreateBkmInitializeRequestBuilder.Create()
                .Price("1")
                .CallbackUrl("https://www.merchant.com/callback")
                .Build();

            BkmInitialize bkmInitialize = BkmInitialize.Create(request, Options);

            PrintResponse(request);

            Assert.NotNull(bkmInitialize.HtmlContent);
            Assert.NotNull(bkmInitialize.Token);
            Assert.True(bkmInitialize.HtmlContent.Contains(bkmInitialize.Token));
        }
    }
}
