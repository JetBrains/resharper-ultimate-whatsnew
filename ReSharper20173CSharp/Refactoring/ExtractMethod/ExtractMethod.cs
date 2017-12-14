using System;

namespace ReSharper20173CSharp.Refactoring.ExtractMethod
{
    class ExtractMethod
    {
        public Point GetPoint()
        {
            // We can now rewrite deconstructing declaration to assignment.
            // Extract new method (not local function) from here:
            (int x, int y, int z) = GetCoords();
            Console.WriteLine($"Current position is: X={x}, Y={y}, Z={z}");
            // To here
            return new Point(x, y);
        }

        private (int x, int y, int z) GetCoords() => (0, 1, 2);

        public class Point
        {
            public int X { get; set; }
            public int Y { get; set; }
            
            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
        }
    }
}