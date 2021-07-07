using System;

namespace ReSharper20193CSharp
{
    public class LocalizationManager
    {
        public static void Example()
        {
            // 1. Open ReSharper | Windows | Localization Manager

            // 2. Add a new culture and translate the following resource
            var helloWorld1 = Labels.HelloWorld;

            // 3. Add a new resource based on this string. Use Refactor This or Alt+Enter and move to resource.
            Console.WriteLine("Another label");

            // 4. Rename this resource using the Localization Manager or Refactor This
            var helloWorld2 = Labels.HelloWorld;

            // 5. Safe delete UnusedResource
            // Labels.HelloWorld
        }
    }
}
