namespace ReSharper20182CSharp
{
    public class RefLocalAssignments
    {
        void Example1(ref int parameter)
        {
            // Now alsoParameter is also a reference, modifications to alsoParameter are made on the original
            ref var alsoParameter = ref parameter;

            // This copies the value, modifying it has no effect on the original
            var copyOfParameter = parameter;
        }

        void Example2()
        {
            // person is now a copy of the Person that was returned
            var person = GetPerson(123);

            // personRef is now a reference to the Person that was returned. Any change made to the personRef is reflected on the original
            ref var personRef = ref GetPerson(123);
        }

        public ref Person GetPerson(int id)
        {
            var people = new []
            {
                new Person()
            };

            return ref people[0]; 
        }

        public class Person
        {
            public string Name { get; set; }
        }
    }
}