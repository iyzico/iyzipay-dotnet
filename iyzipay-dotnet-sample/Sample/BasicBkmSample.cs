using Microsoft.VisualStudio.TestTools.UnitTesting;
using Iyzipay.Request;
using Iyzipay.Model;
using System.Collections.Generic;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class BasicBkmSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Bkm_Express()
        {
            CreateBasicBkmInitializeRequest request = new CreateBasicBkmInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "1";
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            // prepare buyer
            request.BuyerId = "100";
            request.BuyerEmail = "email@email.com";
            request.BuyerIp = "85.34.78.112";

            // default pos
            request.ConnectorName = "connector name";
            request.InstallmentDetails = prepareInstallmentDetails();
            BasicBkmInitialize bkmInitialize = BasicBkmInitialize.Create(request, options);

            PrintResponse<BasicBkmInitialize>(bkmInitialize);

            Assert.IsNotNull(bkmInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), bkmInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), bkmInitialize.Locale);
            Assert.AreEqual("123456789", bkmInitialize.ConversationId);
            Assert.IsNotNull(bkmInitialize.HtmlContent);
        }

        [TestMethod]
        public void Should_Retrieve_Bkm_Auth()
        {
            RetrieveBkmRequest request = new RetrieveBkmRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "token";

            BasicBkm basicBkm = BasicBkm.Retrieve(request, options);

            PrintResponse<BasicBkm>(basicBkm);

            Assert.IsNotNull(basicBkm.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), basicBkm.Status);
            Assert.AreEqual(Locale.TR.GetName(), basicBkm.Locale);
            Assert.AreEqual("123456789", basicBkm.ConversationId);
        }

        private List<BkmInstallment> prepareInstallmentDetails()
        {
            List<BkmInstallment> installmentDetails = new List<BkmInstallment>();
            installmentDetails.Add(isbankInstallmentDetails());
            installmentDetails.Add(finansbankInstallmentDetails());
            installmentDetails.Add(akbankInstallmentDetails());
            installmentDetails.Add(ykbInstallmentDetails());
            installmentDetails.Add(denizbankInstallmentDetails());
            installmentDetails.Add(halkbankInstallmentDetails());
            return installmentDetails;
        }

        private BkmInstallment isbankInstallmentDetails () 
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 64L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>() ;

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        private BkmInstallment finansbankInstallmentDetails()
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 111L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>();

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        private BkmInstallment akbankInstallmentDetails() 
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 46L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>();

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        private BkmInstallment ykbInstallmentDetails()
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 67L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>();

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        private BkmInstallment denizbankInstallmentDetails() 
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 134L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>();

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }

        private BkmInstallment halkbankInstallmentDetails()
        {
            BkmInstallment installmentDetail = new BkmInstallment();
            installmentDetail.BankId = 12L;

            List<BkmInstallmentPrice> installmentPrices = new List<BkmInstallmentPrice>();

            BkmInstallmentPrice singleInstallment = new BkmInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BkmInstallmentPrice twoInstallments = new BkmInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice threeInstallments = new BkmInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BkmInstallmentPrice sixInstallments = new BkmInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BkmInstallmentPrice nineInstallments = new BkmInstallmentPrice();
            nineInstallments.InstallmentNumber = 9;
            nineInstallments.TotalPrice = "1.4";

            installmentPrices.Add(singleInstallment);
            installmentPrices.Add(twoInstallments);
            installmentPrices.Add(threeInstallments);
            installmentPrices.Add(sixInstallments);
            installmentPrices.Add(nineInstallments);

            installmentDetail.InstallmentPrices = installmentPrices;
            return installmentDetail;
        }
    }
}
