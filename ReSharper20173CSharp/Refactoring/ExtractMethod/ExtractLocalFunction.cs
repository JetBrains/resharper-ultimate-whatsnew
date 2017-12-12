using System;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class ExtractLocalFunction
    {
        public void Code()
        {
            var url = "https://www.jetbrains.com/";

            // Extract the following piece of code into a local function
            if (!url.EndsWith("/"))
            {
                url = url + "/";
            }

            Console.WriteLine(url);
        }
    }
}