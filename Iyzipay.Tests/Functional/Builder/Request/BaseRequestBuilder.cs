namespace Iyzipay.Tests.Functional.Builder.Request
{
    public abstract class BaseRequestBuilder
    {
        protected string Locale { get; set; } = Model.Locale.TR.ToString();
        protected string ConversationId { get; set; } = "123456789";
    }
}
