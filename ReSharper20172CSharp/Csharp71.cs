using System.Collections.Generic;
using System.Threading.Tasks;
// ReSharper disable UnusedVariable

namespace ReSharper20172CSharp
{
    public class Csharp71
    {
        public static async Task Main()
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
    }
}
