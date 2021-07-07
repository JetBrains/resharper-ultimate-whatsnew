using System;
// ReSharper disable UnusedVariable

namespace ReSharper20181CSharp.ValueTracking
{
	// minor modification
    public class RefReturning
    {
        public static void Init()
        {
            var p1 = new Player("Scott", new Point(x: 100, y: 200));
            var p2 = new Player("Brian", new Point(x: -1, y: -5));

            var position = new Point(x: 50, y: 75);
            var closestPlayer = GamePlay.GetClosestPlayer(ref position, ref p1, ref p2);
        }

        public class GamePlay
        {
            public static ref Player GetClosestPlayer(ref Point position, ref Player p1, ref Player p2)
            {
                if (position.GetDistance(p1.Position) < position.GetDistance(p2.Position))
                    return ref p1;

                return ref p2;
            }
        }

        public struct Player
        {
            public Player(string name, Point position)
            {
                Name = name;
                Position = position;
            }

            public string Name { get; }
            public Point Position { get; }
        }

        public struct Point
        {
            public int X { get; }
            public int Y { get; }

            public Point(int x, int y)
            {
                X = x;
                Y = y;
            }
            public int GetDistance(Point position) { throw new NotImplementedException(); }
        }
    }
}
