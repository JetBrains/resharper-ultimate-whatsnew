using System;

namespace ReSharper20162CSharp
{
    public class LocaliseInterpolatedStrings
    {
        public void Say(string message)
        {
            // 20162RTM: Non-localised interpolated string, highlighted as warning
            // "Move to resource" available as both quick fix and via refactoring
            Console.WriteLine($"Hello {message}");
        }
    }
}