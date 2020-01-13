using System;
using System.Linq;

namespace Iyzipay.Tests.Functional.Util
{
    public class RandomGenerator
    {
        private static readonly Random Random = new Random();
        private const int IdLength = 11;

        public static string RandomId => RandomAlphanumeric(IdLength);

        private static string RandomAlphanumeric(int length)
        {
            const string chars = "ABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
            return new string(Enumerable.Repeat(chars, length).Select(s => s[Random.Next(s.Length)]).ToArray());
        }
    }
}
