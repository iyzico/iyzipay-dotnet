namespace Iyzipay.Tests.Functional.Builder.Request
{
    public abstract class BaseRequestBuilder
    {
        protected string _locale { get; set; } = Model.Locale.TR.ToString();
        protected string _conversationId { get; set; } = "123456789";
    }
}
