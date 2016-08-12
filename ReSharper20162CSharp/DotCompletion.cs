using System.Text;

namespace ReSharper20162CSharp
{
    public class DotCompletion
    {
    //20162EAP1: Typing assistance: dot/semicolon inside parentheses, dot after semicolon
    private string Foo(StringBuilder myStringBuilder)
    {
      //myStringBuilder.AppendLine(.)
        return null;
      }
    }
}
