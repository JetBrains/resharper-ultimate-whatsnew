// ReSharper disable UnusedVariable

using System;
using System.Collections.Generic;

namespace ReSharper20172CSharp
{
    public class InspectionOutVariables
    {
        public class InlineVarInspection
        {
            public void InlineVar1()
            {
                // Use context action to inline variable
                int result;
                if (int.TryParse("42", out result))
                {
                    Console.WriteLine(result);
                }
            }

            public void InlineVar2(Dictionary<int, string> items)
            {
                string result;
                items.TryGetValue(42, out result);
            }
        }

        public class UseVarInspection
        {
            public void OutVarToType()
            {
                // Use context action to change out var to specify type directly
                var value = "42";
                if (int.TryParse(value, out var result))
                {
                    // ...
                }
            }

            public void OutTypeToVar()
            {
                // Use context action to change out int to use var
                var value = "42";
                if (int.TryParse(value, out int result))
                {
                    // ...
                }
            }
        }
    }
}