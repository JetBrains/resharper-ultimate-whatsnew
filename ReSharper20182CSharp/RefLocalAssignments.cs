using System;

namespace ReSharper20182CSharp
{
    public class RefLocalAssignments
    {
        public static void Example1(ref int parameter)
        {
            // Now alsoParameter is also a reference, modifications to alsoParameter are made on the original
            ref var alsoParameter = ref parameter;

            // This copies the value, modifying it has no effect on the original
            var copyOfParameter = parameter;
        }

        public static void Example2()
        {
            var people = new[]
            {
                new Person { Name = "Person 1" },
                new Person { Name = "Person 2" },
                new Person { Name = "Person 3" },
                new Person { Name = "Person 4" }
            };

            // person is now a copy of the Person that was returned
            var person = GetPerson(people, 1);

            // Introduced in C# 7.2:
            // personRef is now a reference to the Person that was returned. Any change made to the personRef is reflected on the original object
            ref var personRef = ref GetPerson(people, 1);
            personRef.Name = "Test";
            
            // people[1].Name == "Test" by modifying the original object
        }

        public static void Example3()
        {
            var people = new[]
            {
                new Person { Name = "Person 1" },
                new Person { Name = "Person 2" },
                new Person { Name = "Person 3" },
                new Person { Name = "Person 4" }
            };

            ref var personRef = ref GetPerson(people, 1);
            
            // Introduced in C# 7.3:
            // Assigning personRef will *replace* the original element in our array
            personRef = new Person { Name = "Person X" }; // re-assign people[1] under the hood
            
            // people[1].Name == "Person X" by REPLACING the original object
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