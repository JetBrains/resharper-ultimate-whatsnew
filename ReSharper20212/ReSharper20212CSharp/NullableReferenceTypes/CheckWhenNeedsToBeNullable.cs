#pragma warning disable 8618
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

#nullable enable

namespace ReSharper20212CSharp.NullableReferenceTypes
{
    public class RedundantSuppressions
    {
        public static void Greetings()
        {
            var person1 = TryFindPerson("Jane Doe");
            person1!.SayHello(); // 2. See ! become grayed out, Alt+Enter, remove redundant suppression

            var person2 = TryFindPerson("John Doe");
            person2!.SayHello(); // 3. See ! become grayed out, Alt+Enter, "find nullable warning suppressions"

        }

        // 1. Caret on ?, Alt+Enter, make type not nullable
        static Person? TryFindPerson(string name) => new() { Name = name };
    }

    public class Person
    {
        public string Name { get; set; }

        public void SayHello()
        {

        }
    }
}