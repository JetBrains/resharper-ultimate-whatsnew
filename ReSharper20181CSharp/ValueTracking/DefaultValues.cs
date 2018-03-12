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

        public static void SaveToDatabase(Person p, bool log = false)
        {
            if (log)
                Console.WriteLine($"Saving {p.Fullname} to database.");

            // saving
        }
        
        public class Person
        {
            public string Forename { get; }
            public string Surname { get; }
            public string Fullname => $"{Forename} {Surname}";

            public Person(string forename, string surname)
            {
                Forename = forename;
                Surname = surname;
            }
        }
    }
}
