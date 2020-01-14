using System;

namespace Iyzipay.Request
{
    public class CreateCardManagementPageInitializeRequest : BaseRequest
    {
        public bool AddNewCardEnabled { get; set; }
        public bool ValidateNewCard { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string CardUserKey { get; set; }
        public string CallbackUrl { get; set; }
        public bool DebitCardAllowed { get; set; }
        
        public override String ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .AppendSuper(base.ToPKIRequestString())
                .Append("addNewCardEnabled", AddNewCardEnabled.ToString().ToLower())
                .Append("validateNewCard", ValidateNewCard.ToString().ToLower())
                .Append("externalId", ExternalId)
                .Append("email", Email)
                .Append("cardUserKey", CardUserKey)
                .Append("callbackUrl", CallbackUrl)
                .Append("debitCardAllowed", DebitCardAllowed.ToString().ToLower())
                .GetRequestString();
        }
    }
}