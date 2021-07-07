using System;
// ReSharper disable UnusedVariable
// ReSharper disable ConvertToConstant.Local

namespace ReSharper20181CSharp
{
    public class Deconstruction
    {
        // Setting: Prefer separate declarations for deconstructed variables
        public void K()
        {
            // CA: Specify type explicitly
            // CA: Use separate declaration expressions
            // CA: Use single deconsturction declaration (must all be var)
            (var key, var value) = GetKeyValue();
        }

        public void M()
        {
            var person = new Person
                         {
                             FirstName = "Max",
                             LastName = "Power",
                             YearOfBirth = 1990
                         };

            var (first, last, year) = person;
        }

        public void N()
        {
            // Setting: Use 'var' keyword for discards
            //var _ = default(string);
            O(out _);
            //Console.WriteLine(_);
        }

        private (int key, int value) GetKeyValue()
        {
            return (1, 10);
        }

        private string Z(string bla)
        {
            return Z(Z("Oijsodjf"));
        }

        private void O(out string i)
        {
            i = "";
        }

        private class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public int YearOfBirth { get; set; }

            public void Deconstruct(out string firstName, out string lastName, out int yearOfBirth)
            {
                firstName = FirstName;
                lastName = LastName;
                yearOfBirth = YearOfBirth;
            }
        }
    }
}
