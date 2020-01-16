using System;

namespace Iyzipay.Model.Iyzilink
{
    public class IyziLinkSave : RequestStringConvertible
    {
        public string Token { get; set; }
        public string Url { get; set; }
        public string ImageUrl { get; set; }

        public string ToPKIRequestString()
        {
            return ToStringRequestBuilder.NewInstance()
                .Append("token", Token)
                .Append("url", Url)
                .Append("imageUrl", ImageUrl)
                .GetRequestString();
        }
    }
}