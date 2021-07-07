using System;
using System.Collections.Generic;

namespace ReSharper20171CSharp
{
    // Highlight, Alt+Enter -> Format Selection -> Configure
    public class CSharpFormatting
    {
        // 'Prefer wrap before ","' - comma first style
        private List<string> myValues = new List<string>
        {
            "Value1",
            "Value2",
            "Value3",
            "Value4",
            "Value5",
            "Value6"
        };

        // Parentheses before and inside nameof expression
        private string myName = nameof(CSharpFormatting);

        // Break line in single line case statement
        public void ShowSwitch(DayOfWeek day)
        {
            switch (day)
            {
                case DayOfWeek.Sunday:
                    break;
                case DayOfWeek.Monday:
                    break;
                case DayOfWeek.Tuesday:
                    break;
                case DayOfWeek.Wednesday:
                    break;
                case DayOfWeek.Thursday:
                    break;
                case DayOfWeek.Friday:
                    break;
                case DayOfWeek.Saturday:
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(day), day, null);
            }
        }
    }
}