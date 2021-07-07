#pragma warning disable 219
namespace ReSharper20172CSharp
{
    public class LanguageInjections
    {
        public void InjectionsHappenHere()
        {
            // Language injection supports XML.
            // Alt+Enter on "Maarten works at JetBrains" and use convert to CDATA. 
            var xml = "<person id=\"1\" name=\"Maarten\">Maarten works at JetBrains</person>";
        }
    }
}