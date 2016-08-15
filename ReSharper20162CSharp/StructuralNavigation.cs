using System;
// ReSharper disable ForCanBeConvertedToForeach

namespace ReSharper20162CSharp
{
    public class StructuralNavigation
    {
        public void DoSomethingElse()
        {
            // 20162RTM: Structural navigation
            // Hit Tab or Shift+Tab to cycle through method parameters
            // Hit Tab or Shift+Tab at the start of the line to indent/outdent
            DoSomething("Hello", "to", "Jason", "Isaacs");
        }

        public void DoSomething(params string[] inputs)
        {
            // Put the text caret on `for` and hit Tab to cycle through
            // the initializer statement, the condition and the iterator
            // For example, 

            for (var i = 0; i < inputs.Length; i++)
            {
                Console.WriteLine(inputs[i]);
            }
        }
    }
}