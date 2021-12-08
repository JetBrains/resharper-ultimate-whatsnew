// ReSharper disable once CheckNamespace
// ReSharper disable UnusedType.Global
// ReSharper disable UnusedVariable

using JetBrains.Annotations;

namespace CSCodeAnalysis;

class Arithmetics
{
    public void ExampleWithInt1()
    {
        var maximumValue = int.MaxValue;

        var overflowingValue = maximumValue + 1;
        var uncheckedValue = unchecked(maximumValue + 1);
    }

    public void ExampleWithInt2(int value)
    {
        var absoluteValue = Math.Abs(value);
        if (absoluteValue < 0)
        {
            // ...
        }
    }

    public void ExampleWithColors(ConsoleColor color)
    {
        switch (color)
        {
            case ConsoleColor.Red:
                Console.WriteLine("Color is red!");
                break;

            case ConsoleColor.Blue:
                Console.WriteLine("Color is blue!");

                if (color == ConsoleColor.Yellow)
                {
                    Console.WriteLine("Color is yellow!");
                }

                break;

            case ConsoleColor.Green:
                Console.WriteLine("Color is green!");
                break;
        }
    }

    public void NewAttributes([NonNegativeValue]int amount, [ValueRange(1, 5)]int rating)
    {
        if (amount < 0)
        {
            // ...
        }

        if (rating > 10)
        {
            // ...
        }
    }
}