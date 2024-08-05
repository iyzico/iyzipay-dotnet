using System;

namespace Iyzipay.Request
{
    public class CreateCardManagementPageInitializeRequest : BaseRequestV2
    {
        public bool AddNewCardEnabled { get; set; }
        public bool ValidateNewCard { get; set; }
        public string ExternalId { get; set; }
        public string Email { get; set; }
        public string CardUserKey { get; set; }
        public string CallbackUrl { get; set; }
        public bool DebitCardAllowed { get; set; }
    }
}