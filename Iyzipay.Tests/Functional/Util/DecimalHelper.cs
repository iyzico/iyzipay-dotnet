namespace Iyzipay.Tests.Functional.Util
{
    public static class DecimalHelper
    {
        public static string RemoveTrailingZeros(this string strdec)
        {
            return strdec.Contains(".") ? strdec.TrimEnd('0').TrimEnd('.') : strdec;
        }
    }
}
