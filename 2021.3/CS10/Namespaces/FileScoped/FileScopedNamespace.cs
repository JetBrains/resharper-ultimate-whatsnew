
#pragma warning disable 8509
#pragma warning disable 8618
#pragma warning disable 8524
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedType.Global


namespace CS10.Namespaces.FileScoped
{
    //Alt+Enter on greyed out "{" above, To file-scoped namespace
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