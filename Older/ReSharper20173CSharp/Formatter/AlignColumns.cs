namespace ReSharper20173CSharp.Deconstructors.Formatter
{
    public class AlignColumns
    {
        public class Person
        {
            public string Name { get; set; }
            public string Age { get; set; }
            public string Country { get; set; }
        }

        public class Example
        {
            public void Demo()
            {
                // Make sure to enable Align Similar Code in Columns for:
                //  - Other Assignments and Initializers
                //  - Properties and Events
                // (under Code Editing | C# | Formatting Style | Other)
                //
                // Then Ctrl+Alt+Enter to reformat code.

                var person = new Person();
                person.Name = "Maarten";
                person.Age = "34";
                person.Country = "Belgium";
            }
        }
    }
}