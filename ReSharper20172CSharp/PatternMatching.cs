using System;

namespace ReSharper20172CSharp
{
    class PatternMatching
    {
        public IShape GenerateShape(string typeOfShape)
        {
            switch (typeOfShape)
            {
                case "circle":
                    return new Circle();
                case "rectangle":
                    return new Rectangle();
            }

            return null;
        }

        public void InspectOldStyle()
        {
            var circle = GenerateShape("circle") as Circle; // Use pattern matching quick-fix
            if (circle != null)
            {
                Console.WriteLine(circle.Radius);
            }
        }
        
        public void GenerateCode(IShape shape)
        {
            switch (shape)
            {
                // Alt+Insert here, Generate type patterns
            }
        }

        public void ConvertToSwitch(IShape shape)
        {
            // Alt+Enter on if, convert to switch statement
            if (shape == null) return;

            if (shape is Circle circle)
            {
                // do circular stuff
            }
            else if (shape is Rectangle rectangle)
            {
                // do rectangular stuff
            }
        }
        
        public interface IShape
        {
        }

        public class Circle : IShape
        {
            public int Radius { get; set; }
        }

        public class Rectangle : IShape
        {
            public int Length { get; set; }
            public int Height { get; set; }
        }
    }
}