using System;
using System.Linq;

namespace ReSharper20182CSharp
{
    /// <summary>
    /// It's probably worth mentioning that the scope of these variables is limited to containing initializer
    /// so the examples from <see cref="DeclarationExpressionsA"/> and <see cref="DeclarationExpressionsB"/>
    /// can be combined and the input variables won't conflict.
    /// </summary>
    public class DeclarationExpressionsB
    {
        // Property initializer with declaration pattern is string str and out var
        public bool InputIsPositiveNumber { get; } = TryReadInputObject() is string str
                                                     && int.TryParse(str, out var input)
                                                     && input > 0;

        public static object TryReadInputObject() => Console.ReadLine();
    }
}