using Iyzipay.Model;
using Iyzipay.Request;
using Iyzipay.Tests.Functional.Builder.Request;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Tests.Functional
{
    public class BkmTest : BaseTest
    {
        [Test]
        public async Task Should_Initialize_BkmAsync()
        {
            CreateBkmInitializeRequest request = CreateBkmInitializeRequestBuilder.Create()
                .Price("1")
                .CallbackUrl("https://www.merchant.com/callback")
                .Build();

            BkmInitialize bkmInitialize = await BkmInitialize.Create(request, _options);

            PrintResponse(request);

            Assert.NotNull(bkmInitialize.HtmlContent);
            Assert.NotNull(bkmInitialize.Token);
            Assert.True(bkmInitialize.HtmlContent.Contains(bkmInitialize.Token));
        }
    }
}
