using System;

namespace ReSharper20171CSharp
{
    class ExpressionBodies
    {
        private string myName;

        // C# 7 convert constructor to expression body and back
        public ExpressionBodies(string name)
        {
            myName = name;
        }

        public string Name
        {
            // C#7 convert accessors to expression body and back
            get { return myName ?? "No name set"; }
            set { myName = value; }
        }

        // C#6 convert to expression body and back
        public void Greet()
        {
            Console.WriteLine($"Hello {Name}");
        }

        public void GreetWithLocalFunction()
        {
            // C#7 convert local function to expression body and back
            string MyLocalFunction(string forename, string surname)
            {
                return forename + " " + surname;
            }

            Console.WriteLine("Hello to " + MyLocalFunction("Jason", "Isaacs"));
        }
    }
}