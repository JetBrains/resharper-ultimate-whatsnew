using System;

namespace ReSharper20162CSharp.ReSharper_2016._2.ReSharper20162CSharp
{
    public class LocaliseInterpolatedStrings
    {
        public void Say(string message)
        {
            // Non-localised interpolated string, highlighted as warning
            // "Move to resource" available as both quick fix and via refactoring
            Console.WriteLine($"Hello {message}");
        }
    }
}