// <copyright file="ApiTestSample.cs" company="Iyzico">
// Copyright (c) 2016 All Rights Reserved
// </copyright>
// <summary></summary>
namespace IyzipaySample.Sample
{
    using Iyzipay;
    using Iyzipay.Model;
    using Microsoft.VisualStudio.TestTools.UnitTesting;

    /// <summary>
    /// API test sample
    /// </summary>
    /// <seealso cref="IyzipaySample.Sample.Sample" />
    /// <summary>
    /// ApiTestSample
    /// </summary>
    [TestClass]
    public class ApiTestSample : Sample
    {
        /// <summary>
        /// Should test API.
        /// </summary>
        [TestMethod]
        public void ShouldTestApi()
        {
            var iyzipayResource = ApiTest.Retrieve(Options);

            this.PrintResponse<IyzipayResource>(iyzipayResource);

            Assert.IsNotNull(iyzipayResource.SystemTime);
            Assert.AreEqual(Status.SUCCESS.ToString(), iyzipayResource.Status);
        }
    }
}
