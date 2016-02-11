// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
// ReSharper disable UnusedVariable
namespace ReSharper101CSharp
{
    public class StringActions
    {
        private void ShowcaseStringActions(string input)
        {
            // 101EAP1: Inspection "Redundant string verbatimity sign" + QF
            string s = $@"{input} yo";

            // 101EAP1: Inspection "Redundant verbatim identifier" + QF
            string @from = input;

            // 101EAP1: CA "Use String.Equals() method"
            var areEqual = "a" == "A";
        }

    }
}