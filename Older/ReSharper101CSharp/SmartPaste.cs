// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local
#pragma warning disable 219
namespace ReSharper101CSharp
{
    public class SmartPaste
    {
        // creator.Create<Creation>(c => c.Nonsense = new A<B<C<D>>>().GetHashCode() >= 0 && true.CompareTo(false) <= 0);
        // 20161RTM: Smart Paste (result of smart pasting the code snippet shown above into an XML doc comment)
        /// <summary>
        /// Contains use cases for Smart Paste feature
        /// </summary>
        /// <example>creator.Create&lt;Creation&gt;(c =&gt; c.Nonsense = new A&lt;B&lt;C&lt;D&gt;&gt;&gt;().GetHashCode() &gt;= 0 &amp;&amp; true.CompareTo(false) &lt;= 0);</example>
        private void ShowcaseSmartPasteInCSharp()
        {
            /*
               var p = Test();
               var s = p.ToString(); // Warning: Possible "System.NullReferenceException"
            */
            // 20161RTM: Smart Paste (result of smart pasting the code snippet shown above)
            var pastedCodeSnippet = "var p = Test();\r\n               var s = p.ToString(); // Warning: Possible \"System.NullReferenceException\"";

            // 20161RTM: Smart Paste (result of smart pasting string literal from a regular string literal (pastedCodeSnippet) to a verbatim string literal)
            var pastedFromRegularToVerbatim = @"var p = Test();
                var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'";

            // <member name="T:JetBrains.Annotations.NotNullAttribute">
            // 20161RTM: Smart Paste (result of smart pasting the XML snippet shown above)
            var pastedXmlSnippet = "<member name=\"T:JetBrains.Annotations.NotNullAttribute\">";

            // C:\nameOfFolder
            // 20161RTM: Smart Paste (result of smart pasting the path shown above)
            var pastedWindowsPath = "C:\\nameOfFolder";
        }
    }
}