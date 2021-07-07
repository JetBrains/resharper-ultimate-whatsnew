using System.Text;

namespace ReSharper20162CSharp
{
    public class TypingAssistance
    {
        private string Foo(StringBuilder myStringBuilder)
        {
            // 20162RTM: Typing assistance: dot/semicolon inside parentheses, dot after semicolon 
            // (a chain of all three shown here: https://twitter.com/controlflow/status/734508760761270272/)

            // 1. dot inside parentheses: 
            //            myStringBuilder.AppendLine(.) -> myStringBuilder.AppendLine().{caret}

            // 2. Semicolon inside parentheses: 
            //            myStringBuilder.AppendLine(;) -> myStringBuilder.AppendLine({caret});

            // 3. dot after semicolon: 
            //            myStringBuilder.AppendLine().Capacity;. -> myStringBuilder.AppendLine().Capacity.{caret};

            return null;
        }
    }
}