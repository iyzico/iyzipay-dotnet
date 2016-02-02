using Iyzipay;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace iyzipay_dotnet_sample.Sample
{
    [TestClass]
    public class Sample
    {
        protected Options options;

        [TestInitialize()]
        public void Initialize()
        {
            options = new Options();
            options.ApiKey = "apiKey";
            options.SecretKey = "secretKey";
            options.BaseUrl = "baseUrl";
        }
    }
}
