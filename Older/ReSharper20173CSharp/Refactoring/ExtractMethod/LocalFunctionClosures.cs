using System;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class LocalFunctionClosures
    {
        public void Method(string word)
        {
            // If you choose to place new local function here it will create a parameter for the 'message' variable
            (int index, bool found) = FindWord(word);
            if (found)
            {
                var message = $"Word '{word}' is found at index {index}";

                // Select this statement and extract a local function (Ctrl+R, M)
                Console.WriteLine(message);

                // If you choose to place new local function here it will use 'message' as a closure
            }
        }

        private static (int, bool) FindWord(string word) => (12, true);
    }
}