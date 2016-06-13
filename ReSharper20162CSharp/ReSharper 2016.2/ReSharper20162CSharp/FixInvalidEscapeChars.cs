using System;

namespace ReSharper20162CSharp.ReSharper_2016._2.ReSharper20162CSharp
{
    public class FixInvalidEscapeChars
    {
        public void InvalidEscapeChars()
        {
            // Fix invalid escape chars by 
            Console.WriteLine("C:\invalid\chars");
            Console.WriteLine("C:\more\invalid\chars");
        }
    }
}