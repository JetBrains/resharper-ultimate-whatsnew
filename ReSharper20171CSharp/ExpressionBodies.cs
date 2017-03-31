using System;

namespace ReSharper20171CSharp
{
    class ExpressionBodies
    {
        private string myName;

        // C# 7 convert constructor to expression body
        public ExpressionBodies(string name)
        {
            myName = name;
        }

        public string Name
        {
            // C#7 convert accessors to expression body
            get { return myName ?? "No name set"; }
            set { myName = value; }
        }

        // C#6 convert to expression body
        public void Greet()
        {
            Console.WriteLine($"Hello {Name}");
        }
    }
}