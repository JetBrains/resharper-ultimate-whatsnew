using System;
using System.Linq;

namespace ReSharper20182CSharp
{
    /// <summary>
    /// It's probably worth mentioning that the scope of these variables is limited to containing initializer
    /// so the examples from <see cref="DeclarationExpressionsA"/> and <see cref="DeclarationExpressionsB"/>
    /// can be combined and the input variables won't conflict.
    /// </summary>
    public class DeclarationExpressionsA
    {
        // Field initializer with var input declaration expression in out argument
        public bool inputIsPositiveNumber = int.TryParse(ReadString(), out var input) && input > 0;

        public static string ReadString() => Console.ReadLine();
    }
}