using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System;
// ReSharper disable ClassNeverInstantiated.Local

// ReSharper disable UnusedVariable
namespace ReSharper20172CSharp
{
    public class Csharp71
    {
        // C# 7.1 async main support
        public static async Task Main(string[] args)
        {
            // C# 7.1 default literal: Inspection shows (List<string>) is redundant and can be removed.
            // Alt+Enter, Remove Redundant type specification.
            List<string> someList = default(List<string>);

            var someString = Create<string>();
            var someInt = Create<int>();

            await Task.Delay(1000);
        }

        private static T Create<T>()
        {
            // C# 7.1 default literal: Inspection shows (List<string>) is redundant and can be removed.
            // Alt+Enter, Remove Redundant type specification.
            return default(T);
        }

        // C# 7.1 tuple projection initializers
        // https://github.com/dotnet/csharplang/blob/master/proposals/csharp-7.1/infer-tuple-names.md
        private void TupleProjectionInitializers()
        {
            var list = new List<Person>();

            // Before C# 7.1
            var item = list
                .Select(p => new { p.Name, p.Age })
                .FirstOrDefault(p => p.Age > 21);

            // C# 7.1 With tuples/projection initializers
            (var name, var age) = list
                .Select(p => (p.Name, p.Age))
                .FirstOrDefault(tuple => tuple.Age > 21);

            // New inspection: Redundant value tuple component name 
            (var name1, var age1) = list
                .Select(p => (Name: p.Name, Age: p.Age)) // should be visible here
                .FirstOrDefault(tuple => tuple.Age > 21);
        }

        class Person
        {
            public string Name { get; set; }
            public string Email { get; set; }
            public int Age { get; set; }
        }
    }
}
