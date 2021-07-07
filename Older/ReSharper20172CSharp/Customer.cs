using System;
using JetBrains.Annotations;

namespace ReSharper20172CSharp
{
    public class Customer
    {
        // name now provides "Initialize auto-property from parameter" context action
        // with options like making it public mutable, ...
        //
        // Alt+Enter on name in the constructor declaration.
        public Customer([NotNull] string name)
        {
            if (string.IsNullOrEmpty(name))
            {
                throw new ArgumentException("Value cannot be null or empty.", nameof(name));
            }
        }
    }
}