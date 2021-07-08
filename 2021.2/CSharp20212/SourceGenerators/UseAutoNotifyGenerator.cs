using System;
using AutoNotify;

namespace CSharp20212.SourceGenerators
{
    public partial class PersonViewModel
    {
        [AutoNotify(PropertyName = "JobTitle")]
        private string _jobTitle;

        [AutoNotify] private int _age;
        [AutoNotify] private string _name = "John Doe";
        [AutoNotify] private string _title = "Dr.";
    }

    public static class UseAutoNotifyGenerator
    {
        public static void Run()
        {
            var person = new PersonViewModel();
            var name = person.Name;
            Console.WriteLine($"FirstName = {name}");
            Console.WriteLine($"Age = {person.Age}");

            person.PropertyChanged += (_, e)
                => Console.WriteLine($"Property {e.PropertyName} was changed");

            person.Age++;
            Console.WriteLine($"Age = {person.Age}");
        }
    }
}