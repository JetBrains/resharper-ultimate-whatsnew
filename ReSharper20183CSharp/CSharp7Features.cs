using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharper20183CSharp
{
    public class CSharp7Features
    {
        void IntroduceParameterInLocalFunction(string url)
        {
            // 1. Introduce parameter refactoring for local functions
            //    Alt+Enter on "/", introduce parameter
            url = EnsureTrimmed(url, "/");

            string EnsureTrimmed(string data)
                => data.Trim();
        }

        (string id, bool include) AddExplicitTupleComponentName()
        {
            // 2. Add tuple component name
            //    Alt+Enter in true, add component name to include
            //    Note include comes from method return value signature
            return (null, true);
        }

        public static bool IsBlankOrEmpty(object o)
        {
            // 3. Split 'if' for || expressions in guard clauses
            //    See https://youtrack.jetbrains.com/issue/RSRP-471023
            switch (o)
            {
                case string s when string.IsNullOrEmpty(s) || s.All(c => c == ' '):
                    return true;
                default:
                    return o == null;
            }
        }

        public void DeconstructUsage(Dictionary<int, Person> people)
        {
            // 3. Deconstruct variable into.. on usage
            //    Alt+Enter on pair, deconstruct into
            foreach (var pair in people)
            {
                Console.WriteLine($"Person: {pair.Key} {pair.Value.FirstName}");
            }

            // 4. Start typing: people.foreach{tab}
            //    See suggestion to deconstruct or use a single value
            //
        }

        public void InterpolatedString(string name, int age)
        {
            // 5. Quick fix for ?: operator in interpolated string
            //    See code analysis below.
            Console.WriteLine($"{name} is {age:D3} year{age == 1 ? "" : "s"} old.");

            // 6. Detect incorrect use of C# interpolated strings as format strings
            //    The following code looks fine at first glance, but its return value is "0" - not "my text" as you might expect!
            var result1 = string.Format($"{0}", "my text");

            // 7. CA for conversion from string.Concat(...) to string interpolation
            //    Alt+Enter, convert to interpolation
            var result2 = string.Concat(name, " is ", age, "year", age == 1 ? "" : "s", " old");
        }

        public void FillObjectInitializer()
        {
            // 8. Fill object initializer
            var person = new Person()
                         {
                            // Alt+Enter, initialize members
                         };
        }

        public class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int YearOfBirth { get; set; }
        }
    }
}
