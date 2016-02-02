using System;

namespace Iyzipay
{
    public class RequestFormatter
    {
        public static String FormatPrice(String price)
        {
            if (!price.Contains(","))
            {
                return price + ".0";
            }
            int subStrIndex = 0;
            String priceReversed = Reverse(price);
            for (int i = 0; i < priceReversed.Length; i++)
            {
                if (priceReversed[i].Equals('0'))
                {
                    subStrIndex = i + 1;
                }
                else if (priceReversed[i].Equals(','))
                {
                    priceReversed = "0" + priceReversed;
                    break;
                }
                else
                {
                    break;
                }
            }
            return Reverse(priceReversed.Replace(',', '.').Substring(subStrIndex));
        }

        public static string Reverse(string s)
        {
            char[] charArray = s.ToCharArray();
            Array.Reverse(charArray);
            return new string(charArray);
        }
    }
}
