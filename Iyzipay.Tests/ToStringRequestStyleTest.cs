using System.Reflection;
using NUnit.Framework;

namespace Iyzipay.Tests
{
    public class ToStringRequestStyleTest
    {
        private FieldInfo _requestString;

        [SetUp]
        public void SetRequestString()
        {
            _requestString = typeof(ToStringRequestBuilder).GetField("_requestString", BindingFlags.Instance | BindingFlags.NonPublic);
        }

        [Test]
        public void Should_Have_Private_Field_Named_RequestString()
        {
            Assert.NotNull(_requestString);
        }

        [Test]
        public void Should_Append_When_Value_Is_Not_Null()
        {
            var toStringRequestBuilder = ToStringRequestBuilder.NewInstance().Append("conversationId", "123456");
            string requestString = GetRequestStringValue(toStringRequestBuilder);

            Assert.AreEqual("conversationId=123456,", requestString);
        }

        [Test]
        public void should_append_nothing_when_value_is_not_null()
        {
            var toStringRequestBuilder = ToStringRequestBuilder.NewInstance().Append("conversationId", null);
            string requestString = GetRequestStringValue(toStringRequestBuilder);

            Assert.AreEqual(string.Empty, requestString);
        }

        [Test]
        public void Should_Append_When_Value_Is_Empty()
        {
            var toStringRequestBuilder = ToStringRequestBuilder.NewInstance().Append("conversationId", string.Empty);
            string requestString = GetRequestStringValue(toStringRequestBuilder);

            Assert.AreEqual("conversationId=,", requestString);
        }

        private string GetRequestStringValue(ToStringRequestBuilder instance)
        {
            return _requestString.GetValue(instance).ToString();
        }
    }
}
