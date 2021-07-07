using System;
using System.Linq;

namespace ReSharper20182CSharp
{
    public class DeclarationExpressionsC
    {
        public readonly bool WrapsPostiveNumber;
        public readonly int Number;

        private DeclarationExpressionsC(bool wrapsPostiveNumber)
        {
            WrapsPostiveNumber = wrapsPostiveNumber;
        }

        // Constructor initializers
        public DeclarationExpressionsC(string str) : this(int.TryParse(str, out var input) && input > 0)
        {
            // Note that in this case the scope of the declared variable isn't limited
            // to the initializer and it's also visible throughout the constructor's body
            Number = input;
        }
    }
}