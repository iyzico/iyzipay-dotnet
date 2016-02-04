using System;
using System.Text;

namespace Iyzipay
{
    public sealed class DigestHelper
    {
        private DigestHelper()
        {
        }

        public static String decodeString(String content)
        {
            return (!String.IsNullOrEmpty(content)) ? Encoding.UTF8.GetString(Convert.FromBase64String(content)) : null;
        }
    }
}
