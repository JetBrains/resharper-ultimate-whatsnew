// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
namespace ReSharper101CSharp
{
    public class CSharp6
    {
        private void ShowcaseCSharp6(string input)
        {
            // 101EAP1: CA "Convert string interpolation into string.Format"
            string firstString = $"{input} yay";

            // 101EAP1: CA "Convert concatenation to interpolation"
            string secondString = "Here's my input: " + input;

            // 101EAP1: Refactoring "Introduce variable for substring" supports string interpolation
            string thirdString = string.Concat($"Here\'s my input: {input}");

            // 101EAP1: Inspection "Nested string interpolation can be inlined" + QF
            string fourthString = $"{ $"{input} yay"}";

        }

    }
}