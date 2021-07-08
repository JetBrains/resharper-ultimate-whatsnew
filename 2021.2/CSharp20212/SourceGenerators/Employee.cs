using System;
using AutoNotify;

namespace CSharp20212.SourceGenerators
{
    public partial class Employee
    {
        [AutoNotify] private string _firstName;
        [AutoNotify] private string _lastName;
        [AutoNotify] private int _yearsOld;

        public Employee(string firstName, string lastName, int yearsOld)
        {
            _firstName = firstName;
            _lastName = lastName;
            _yearsOld = yearsOld;
        }

        public void SayHello()
        {
            Console.WriteLine($"Hello, I'm {FirstName} {LastName}!");
        }
    }
}