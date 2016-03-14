using Iyzipay.Model;
using Iyzipay.Request;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace IyzipaySample.Sample
{
    [TestClass]
    public class ConnectBKMSample : Sample
    {
        [TestMethod]
        public void Should_Initialize_Bkm_Express()
        {
            CreateConnectBKMInitializeRequest request = new CreateConnectBKMInitializeRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Price = "3.2";
            request.CallbackUrl = "https://www.merchant.com/callbackUrl";
            //prepare buyer
            request.BuyerId = "100";
            request.BuyerEmail = "email@email.com";
            request.BuyerIp = "192.168.123.102";
            //default pos
            request.ConnectorName = "connector name";
            request.InstallmentDetails = prepareInstallmentDetails();

            ConnectBKMInitialize connectBKMInitialize = ConnectBKMInitialize.Create(request, options);

            PrintResponse<ConnectBKMInitialize>(connectBKMInitialize);

            Assert.IsNotNull(connectBKMInitialize.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectBKMInitialize.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectBKMInitialize.Locale);
            Assert.AreEqual("123456789", connectBKMInitialize.ConversationId);
        }

        [TestMethod]
        public void Should_Retrieve_Bkm_Auth()
        {
            RetrieveBKMAuthRequest request = new RetrieveBKMAuthRequest();
            request.Locale = Locale.TR.GetName();
            request.ConversationId = "123456789";
            request.Token = "token";

            ConnectBKMAuth connectBkmAuth = ConnectBKMAuth.Retrieve(request, options);

            PrintResponse<ConnectBKMAuth>(connectBkmAuth);

            Assert.IsNotNull(connectBkmAuth.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), connectBkmAuth.Status);
            Assert.AreEqual(Locale.TR.GetName(), connectBkmAuth.Locale);
            Assert.AreEqual("123456789", connectBkmAuth.ConversationId);
        }

        private List<BKMInstallment> prepareInstallmentDetails()
        {
            List<BKMInstallment> installmentDetails = new List<BKMInstallment>();

            installmentDetails.Add(isbankInstallmentDetails());
            installmentDetails.Add(finansbankInstallmentDetails());
            installmentDetails.Add(akbankInstallmentDetails());
            installmentDetails.Add(ykbInstallmentDetails());
            installmentDetails.Add(denizbankInstallmentDetails());
            installmentDetails.Add(halkbankInstallmentDetails());

            return installmentDetails;
        }
   
        private BKMInstallment isbankInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 64L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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
       
        private BKMInstallment finansbankInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 111L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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
      
        private BKMInstallment akbankInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 46L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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

        private BKMInstallment ykbInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 67L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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

        private BKMInstallment denizbankInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 134L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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

        private BKMInstallment halkbankInstallmentDetails()
        {
            BKMInstallment installmentDetail = new BKMInstallment();
            installmentDetail.BankId = 12L;

            List<BKMInstallmentPrice> installmentPrices = new List<BKMInstallmentPrice>();

            BKMInstallmentPrice singleInstallment = new BKMInstallmentPrice();
            singleInstallment.InstallmentNumber = 1;
            singleInstallment.TotalPrice = "1";

            BKMInstallmentPrice twoInstallments = new BKMInstallmentPrice();
            twoInstallments.InstallmentNumber = 2;
            twoInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice threeInstallments = new BKMInstallmentPrice();
            threeInstallments.InstallmentNumber = 3;
            threeInstallments.TotalPrice = "1.1";

            BKMInstallmentPrice sixInstallments = new BKMInstallmentPrice();
            sixInstallments.InstallmentNumber = 6;
            sixInstallments.TotalPrice = "1.2";

            BKMInstallmentPrice nineInstallments = new BKMInstallmentPrice();
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
