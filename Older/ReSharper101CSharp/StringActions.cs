// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
namespace ReSharper101CSharp
{
    public class StringActions
    {
        private void ShowcaseStringActions(string input)
        {
            // 20161RTM: Inspection "Redundant string verbatimity sign" + QF
            string s = $@"{input} yo";

            // 20161RTM: Inspection "Redundant verbatim identifier" + QF
            string @from = input;

            // 20161RTM: CA "Use String.Equals() method"
            var areEqual = "a" == "A";
        }

    }
}