using System.Globalization;
using NUnit.Framework;

namespace Iyzipay.Tests
{
    public class RequestFormatterTest
    {
        [Test]
        public void Should_Format_Price_Given_String_Value()
        {
            Assert.AreEqual("0.0", RequestFormatter.FormatPrice("0"));
            Assert.AreEqual("0.0", RequestFormatter.FormatPrice("0.0"));
            Assert.AreEqual("1.0", RequestFormatter.FormatPrice("1"));
            Assert.AreEqual("1.0", RequestFormatter.FormatPrice("1.0"));
            Assert.AreEqual("1.0", RequestFormatter.FormatPrice("1.000"));
            Assert.AreEqual("-1.0", RequestFormatter.FormatPrice("-1"));
            Assert.AreEqual("-1.0", RequestFormatter.FormatPrice("-1.0"));
            Assert.AreEqual("-1.0", RequestFormatter.FormatPrice("-1.000"));
            Assert.AreEqual("0.3", RequestFormatter.FormatPrice("0.3"));
            Assert.AreEqual("-0.3", RequestFormatter.FormatPrice("-0.3"));
            Assert.AreEqual("10000.0", RequestFormatter.FormatPrice("10000"));
            Assert.AreEqual("-10000.0", RequestFormatter.FormatPrice("-10000"));
            Assert.AreEqual("99999999999999999999999999.99999999999999999999999", RequestFormatter.FormatPrice("99999999999999999999999999.99999999999999999999999"));
            Assert.AreEqual("-99999999999999999999999999.99999999999999999999999", RequestFormatter.FormatPrice("-99999999999999999999999999.99999999999999999999999"));
        }
    }
}
