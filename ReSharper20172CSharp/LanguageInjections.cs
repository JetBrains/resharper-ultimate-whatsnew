#pragma warning disable 219
namespace ReSharper20172CSharp
{
    public class LanguageInjections
    {
        public void InjectionsHappenHere()
        {
            // Language injection supports escaping path references
            // Paste "C:\Projects\WebApp\bower.json" into the following string:
            var path = "";

            // Language injection supports injected XML
            // Paste the following snippet into the string:
            /*
<?xml version="1.0" encoding="utf-8"?>
<packages>
  <package id="Newtonsoft.JSON" version="10.0.2" targetFramework="net462" />
</packages>
             */
            var xml = "";
        }
    }
}