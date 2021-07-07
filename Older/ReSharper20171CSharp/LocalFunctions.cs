using System;

namespace ReSharper20171CSharp
{
    class LocalFunctions
    {
        static void Main(string[] args)
        {
            Func<int, int> factorial = null;
            factorial = x =>
            {
                if (x <= 1)
                    return 1;

                return x * factorial(x - 1);
            };

            Console.WriteLine(factorial(5));
            Console.ReadKey();
        }
    }
}
