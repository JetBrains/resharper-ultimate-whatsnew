using System;
// ReSharper disable ArgumentsStyleLiteral

namespace ReSharper20181CSharp.ValueTracking
{
    public class PatternMatching
    {
        private static void Main ()
        {
            IsEven(0);
            IsEven(1337);
            IsEven("2018");
            IsEven("2018.1");

            IsOdd(0);
            IsOdd(1337);
            IsOdd("2018");
            IsOdd("2018.1");
        }

        public static bool IsEven (object o)
        {
            switch (o)
            {
                case int i:
                case string s when int.TryParse (s, out i):
                    return i % 2 == 0;
                default:
                    throw new Exception ($"Cannot parse number from {o}.");
            }
        }

        public static bool IsOdd (object o)
        {
            if (o is int i || o is string s && int.TryParse (s, out i))
                return i % 2 == 1;

            throw new Exception ($"Cannot parse number from {o}.");
        }
    }
}