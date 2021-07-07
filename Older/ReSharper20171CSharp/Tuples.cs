using System;

namespace ReSharper20171CSharp
{
    class Tuples
    {
        public void TupleExamples()
        {
            var name = GetName();
            Console.WriteLine($"Hello to {name.forename} {name.surname}");

            var x = (1, 2);

            // Correct type inference, value analysis/dead code
            var (value1, value2) = x;
            Console.WriteLine(value1);

            var p = new Person("Matt", "Ellis");

            // Go to declaration on brackets
            var (forename, surname) = p;
            var (name1, name2) = p;
        }
        
        private static (string forename, string surname) GetName()
        {
            return ("Jason", "Isaacs");
        }

        private class Person
        {
            private readonly string myForename;
            private readonly string mySurname;

            public Person(string forename, string surname)
            {
                myForename = forename;
                mySurname = surname;
            }

            // Find usages on Deconstruct
            public void Deconstruct(out string forename, out string surname)
            {
                forename = myForename;
                surname = mySurname;
            }
        }

        abstract class Base
        {
            public abstract (string name, string surname) GetPerson();
        }

        class Derived : Base
        {
            // "surnmae" typo detection
            public override (string name, string surnmae) GetPerson() => ("Jane", "Doe");
        }
    }
}