// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
namespace ReSharper101CSharp
{
    public class CSharp6
    {
        private void ShowcaseCSharp6(string input)
        {
            // 20161RTM: CA "Convert string interpolation into string.Format"
            string firstString = $"{input} yay";

            // 20161RTM: CA "Convert concatenation to interpolation"
            string secondString = "Here's my input: " + input;

            // 20161RTM: Refactoring "Introduce variable for substring" supports string interpolation
            string thirdString = string.Concat($"Here\'s my input: {input}");

            // 20161RTM: Inspection "Nested string interpolation can be inlined" + QF
            string fourthString = $"{ $"{input} yay"}";

        }

    }
}