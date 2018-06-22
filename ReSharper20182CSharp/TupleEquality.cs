using System;

namespace ReSharper20182CSharp
{
    public class TupleEquality
    {
        private static (string firstname, string surname) GetName()
        {
            return ("Jason", "Isaacs");
        }

        public void Equality()
        {
            var a = ("Jason", "Isaacs");
            var b = GetName();
            
            if (a == b)
            {
                // Seems our tuples are equal
            }
        }

        public void EqualityWithNullables()
        {
            var a = ((DateTime?)null, (DateTime?)null);
            var b = (DateTime.UtcNow, DateTime.UtcNow);

            if (a == b)
            {
                // Seems our tuples are equal
            }
        }
    }
}