using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ReSharper20182CSharp
{
    public class TypeConstraints
    {
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

        int DoSomething<T>(T value) where T : unmanaged
        {
            // ...

            return 0;
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