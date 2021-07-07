using System.Collections.Generic;

#pragma warning disable 8509
#pragma warning disable 8618
#pragma warning disable 8524
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

#nullable enable

namespace CSharp20212.NullableReferenceTypes
{
    public class Employees
    {
        private readonly List<Person> _supportEngineers;
        private readonly List<Person> _softwareEngineers;

        public Employees(List<Person> supportEngineers, List<Person> softwareEngineers)
        {
            _supportEngineers = supportEngineers;
            _softwareEngineers = softwareEngineers;
        }

        public IEnumerable<Person> AllEmployees
        {
            get
            {
                var employees = new List<Person>();
                employees.AddRange(_supportEngineers);
                employees.AddRange(_softwareEngineers);

                return employees;
            }
        }

        // 1. Add ? to Person (or caret on person, Refactor This -> Make nullable)
        // 2. See refactoring show up in gutter, use it ("Apply nullability change")
        // 3. Review type changes, see class will be updated
        // 4. Apply, see List<Person?> etc. everywhere
        public void AddEmployee(Person person, Role role)
        {
            var targetList = role switch
            {
                Role.SupportEngineer => _supportEngineers,
                Role.SoftwareEngineer => _softwareEngineers,
            };

            targetList.Add(person);
        }
    }

    public enum Role
    {
        SupportEngineer,
        SoftwareEngineer
    }
}