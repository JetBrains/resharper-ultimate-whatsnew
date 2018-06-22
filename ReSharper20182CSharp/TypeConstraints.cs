using System;
using System.Collections.Generic;

namespace ReSharper20182CSharp
{
    public class TypeConstraints
    {
        public static IEnumerable<string> GetValues<T>()
            where T : System.Enum
        {
            var enumType = typeof(T);
            var items = Enum.GetValues(enumType);

            foreach (var item in items)
            {
                yield return Enum.GetName(enumType, item);
            }
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