using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReSharper20182CSharp
{
    public class TypeConstraints
    {
        // Enum constraint
        public static IEnumerable<string> GetValues<T>()
            where T : struct, System.Enum
        {
            var enumType = typeof(T);
            var items = Enum.GetValues(enumType);

            foreach (var item in items)
            {
                yield return Enum.GetName(enumType, item);
            }
        }

        // Delegate constraint
        private void CombineDelegates()
        {
            void Hello() => Console.WriteLine("Hello");
            Action world = () => Console.WriteLine("World");

            var helloWorld = Combine(Hello, world);

            Func<bool> test = () => true;

            // Will not compile - not the same Delegate type
            // var helloWorld2 = Combine(Hello, test);
        }

        public static TDelegate Combine<TDelegate>(TDelegate source, TDelegate target)
            where TDelegate : Delegate
        {
            return (TDelegate)Delegate.Combine(source, target);
        }

        // Unmanaged constraint - all unsafe constructs at your disposal
        private static unsafe void DoSomething<T>(T value) 
            where T : unmanaged
        {
            // get size
            int size = sizeof(T);

            // get address and store it to pointer variable
            T* a = &value;

            // allocate array on stack
            T* arr = stackalloc T[42];

            // allocate array on heap and pin it
            fixed (T* p = new T[42])
            {
                // ...
            }
        }

        // Unmanaged constraint - Alt+Enter on "T*"
        static unsafe void SomeMethod<T>(T* p)
        {
            // ...
        }

        // .NET 2.0 example
        public class Repository<T>
            where T : IEntity, new()
        {
            // ...
        }

        public interface IEntity { }
    }
}