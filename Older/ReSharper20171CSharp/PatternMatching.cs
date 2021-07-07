using System;

namespace ReSharper20171CSharp
{
    class PatternMatching
    {
        public void Example(Shape shape)
        {
            // Pattern matching
            switch (shape)
            {
                case Circle c:
                    Console.WriteLine($"circle with radius {c.Radius}");
                    break;
                case Rectangle s when s.Length == s.Height:
                    Console.WriteLine($"{s.Length} x {s.Height} square");
                    break;
                case Rectangle r:
                    Console.WriteLine($"{r.Length} x {r.Height} rectangle");
                    break;
            }
        }

        public class Circle : Shape
        {
            public int Radius { get; set; }
        }

        public class Rectangle : Shape
        {
            public int Length { get; set; }
            public int Height { get; set; }
        }

        public class Shape
        {
        }
    }
}