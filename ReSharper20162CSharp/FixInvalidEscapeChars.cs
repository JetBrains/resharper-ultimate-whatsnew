using System;

namespace ReSharper20162CSharp
{
    public class FixInvalidEscapeChars
    {
        public void InvalidEscapeChars()
        {
            // 20162RTM: Fix invalid escape chars with verbatim string or proper escaping
            Console.WriteLine("C:\invalid\chars");
            Console.WriteLine("C:\more\invalid\chars");
        }
    }
}