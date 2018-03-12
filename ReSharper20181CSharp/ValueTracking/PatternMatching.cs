using System;
using System.Linq;
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
        }

        // Refactor to pattern-matching, mostly doing Alt+Enter
        public static bool IsEven (object o)
        {
            if (o is int)
            {
                var i = (int) o;
                return i % 2 == 0;
            }

            var str = o as string;
            if (str != null)
            {
                int i;
                if (int.TryParse(str, out i))
                    return i % 2 == 0;
            }

            throw new Exception($"Cannot parse number from {o}."); 
        }







        //public static bool IsEven (object o)
        //{
        //    switch (o)
        //    {
        //        case int i:
        //        case string s when int.TryParse(s, out i):
        //            return i % 2 == 0;
        //        default:
        //            throw new Exception($"Cannot parse number from {o}.");
        //    }
        //}

        //public static bool IsEven2 (object o)
        //{
        //    if (o is int i || o is string s && int.TryParse(s, out i))
        //        return i % 2 == 0;
            
        //    throw new Exception($"Cannot parse number from {o}.");
        //}
    }
}