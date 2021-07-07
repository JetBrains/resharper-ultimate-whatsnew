namespace ReSharper20182CSharp
{
    public class RefLocalAssignments
    {
        public static void Example()
        {
            var people = new[]
            {
                new Person { Name = "Person 1" },
                new Person { Name = "Person 2" }
            };

            ref var personRef = ref GetPerson(people, 0);

            // C# 7.2 Assigning personRef to a new Person will *replace* the first original element in our array
            personRef = new Person { Name = "Person X" };
            // people[1] will now be the new person we just assigned

            // C# 7.3 ref-assignment, note the 'ref' keyword in front of the assigned value
            // personRef will not change the value it points to
            // but the assignment will instead change the reference *itself*
            // so now the personRef reference points to the second element of the array
            // and any changes to the personRef will now affect the *second* element
            personRef = ref GetPerson(people, 1);

            // this will change the name of the *second* element of the array
            // even though the reference was initially initialze to point on the first one
            personRef.Name = "Second Person";
        }

        public static ref Person GetPerson(Person[] people, int id)
        {
            return ref people[id];
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}