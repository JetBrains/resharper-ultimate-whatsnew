using System;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class TupleReturn
    {
        public void Method(string word)
        {
            // Select from here
            (int index, bool found) = FindWord(word);
            if (!found)
                Console.WriteLine($"Unable to found word '{word}'");
            // To here. Ctrl+R, M (Extract method), choose method, multiple return values (tuple)
            if (found)
                Console.WriteLine(index);
        }

        private static (int, bool) FindWord(string word) => (12, true);
    }
}