using System;


namespace ReSharper20171CSharp
{
    class LocalFunctions
    {
        //AltEnter on factorial -> To local function
        
        //Then you can convert a local variable to the regular method using a corresponding context action


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
