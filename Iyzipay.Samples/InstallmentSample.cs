﻿using Iyzipay.Request;
using Iyzipay.Model;
using NUnit.Framework;
using System.Threading.Tasks;

namespace Iyzipay.Samples
{
    public class InstallmentSample : Sample
    {
        [Test]
        public async Task Should_Retrieve_InstallmentsAsync()
        {
            RetrieveInstallmentInfoRequest request = new RetrieveInstallmentInfoRequest();
            request.Locale = Locale.TR.ToString();
            request.ConversationId = "123456789";
            request.BinNumber = "554960";
            request.Price = "100";

            InstallmentInfo installmentInfo = await InstallmentInfo.Retrieve(request, options);

            PrintResponse<InstallmentInfo>(installmentInfo);

            Assert.AreEqual(Status.SUCCESS.ToString(), installmentInfo.Status);
            Assert.AreEqual(Locale.TR.ToString(), installmentInfo.Locale);
            Assert.AreEqual("123456789", installmentInfo.ConversationId);
            Assert.IsNotNull(installmentInfo.SystemTime);
            Assert.IsNull(installmentInfo.ErrorMessage);
            Assert.IsNotNull(installmentInfo.InstallmentDetails);
            Assert.IsNotEmpty(installmentInfo.InstallmentDetails);
        }
    }
}
