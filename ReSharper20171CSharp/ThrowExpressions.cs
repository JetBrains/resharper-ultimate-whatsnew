#pragma warning disable IDE0016 // Use 'throw' expression
using System;

namespace ReSharper20171CSharp
{
    class ThrowExpressions
    {
        private string myValue;

        public ThrowExpressions(string value)
        {
            // Convert if null check to assignment with throw expression
            if (value == null) throw new ArgumentNullException(nameof(value));

            myValue = value;
        }

        public void DoSomething(bool condition, out string answer)
        {
            // Convert if statement to ?: ternary expression, with throw statement
            if (condition)
                answer = myValue;
            else
                throw new InvalidOperationException();
        }

        public void SetValue(string newValue)
        {
            // Use tab to complete .throw postfix template to create throw expression
            // myValue = newValue ?? ArgumentNullException.throw
        }
    }
}