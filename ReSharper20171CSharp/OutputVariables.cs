using System;
using System.Collections.Generic;

namespace ReSharper20171CSharp
{
    class OutputVariables
    {
        public void Whatever(IDictionary<string, string> values)
        {
            // Parses correctly. Type inference of var. Go to declaration correct
            if (values.TryGetValue("key", out var value))
            {
                Console.WriteLine(value);
                Console.WriteLine(value);
            }
        }
    }
}