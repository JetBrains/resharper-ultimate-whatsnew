using System;

namespace ReSharper20181CSharp.ValueTracking
{
    public class DefaultValues
    {
        private static void Init()
        {
            SaveToDatabase(new Person("Maarten", "Balliauw"), log: false);
            SaveToDatabase(new Person("Matt", "Ellis"), log: false);
            SaveToDatabase(new Person("Hadi", "Hariri"), log: true);
            SaveToDatabase(new Person("Chris", "Woodruff"), log: false);
        }

        // TODO: find default value for 'log' parameter
        public static void SaveToDatabase(Person p, bool log)
        {
            if (log)
                Console.WriteLine($"Saving {p.Fullname} to database.");

            // saving
        }
        
        public class Person
        {
            public string FirstName { get; }
            public string LastName { get; }
            public string Fullname => $"{FirstName} {LastName}";

            public Person(string firstName, string lastName)
            {
                FirstName = firstName;
                LastName = lastName;
            }
        }
    }
}
