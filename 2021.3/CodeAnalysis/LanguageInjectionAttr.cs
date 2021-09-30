using JetBrains.Annotations;

namespace CSCodeAnalysis;

public class LanguageInjectionAttr
{
    void LanguageInjectionMethod([LanguageInjection(InjectedLanguage.HTML)] out string languageInjectionHTML,
        [LanguageInjection(InjectedLanguage.CSS, Prefix = ".x {", Suffix = ";}")] out string languageInjectionCSS)
    {
        //Start typing valid HTML syntax in quotes, get the code completion, highlighting, code analysis
        languageInjectionHTML = "<div></div>";

        languageInjectionCSS = @"border: 1px solid #0000ff;
                                 padding: 2px;
                                 box-shadow: aquamarine";
    }
}