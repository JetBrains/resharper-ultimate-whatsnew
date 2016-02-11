using System.Collections.Generic;
using JetBrains.Annotations;
#pragma warning disable 219

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local

namespace ReSharper101EAP1
{
    public class ReSharper101EAP1
    {
        // 101EAP1: CAs to split or join attribute sections
        [ItemNotNull, AssertionMethod]
        [ItemCanBeNull]
        [AspDataField]
        public IEnumerable<string> ProcessEnumerable(IEnumerable<string> items)
        {
            // 101EAP1: LINQ transformation suggestions are now downgraded to HINT severity
            foreach (var item in items)
            {
                if (item.EndsWith("suffix"))
                {
                    yield return item;
                }
            }
        }


        // creator.Create<Creation>(c => c.Nonsense = new A<B<C<D>>>().GetHashCode() >= 0 && true.CompareTo(false) <= 0);
        // 101EAP1: Smart Paste (result of smart pasting the code snippet shown above into an XML doc comment)
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
            // 101EAP1: Smart Paste (result of smart pasting the code snippet shown above)
            var pastedCodeSnippet = "var p = Test();\r\n               var s = p.ToString(); // Warning: Possible \"System.NullReferenceException\"";

            // 101EAP1: Smart Paste (result of smart pasting string literal from a regular string literal (pastedCodeSnippet) to a verbatim string literal)
            var pastedFromRegularToVerbatim = @"var p = Test();
                var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'";

            // <member name="T:JetBrains.Annotations.NotNullAttribute">
            // 101EAP1: Smart Paste (result of smart pasting the XML snippet shown above)
            var pastedXmlSnippet = "<member name=\"T:JetBrains.Annotations.NotNullAttribute\">";

            // C:\nameOfFolder
            // 101EAP1: Smart Paste (result of smart pasting the path shown above)
            var pastedWindowsPath = "C:\\nameOfFolder";
        }

        private void ShowcaseStringActions(string input)
        {
            // 101EAP1: Inspection "Redundant string verbatimity sign" + QF
            string s = $@"{input} yo";

            // 101EAP1: Inspection "Redundant verbatim identifier" + QF
            string @from = input;

            // 101EAP1: CA "Use String.Equals() method"
            var areEqual = "a" == "A";
        }

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

        private static void ShowcaseInvertBoolean()
        {
            var feature = new Feature
            {
                Unavailable = false,
                Name = "Invert Boolean Member"
            };

            // 101EAP1: CA "Comment/Uncomment code" (commenting is only available on selection)
            /*
                        var anotherFeature = new Feature
                        {
                            Unavailable = true,
                            Name = "Comment selection"
                        };
            */
        }

        private void TakeManyParametersAndCheckThemAll(string myString, // 101EAP1: CA "Check parameter for null or empty/whitespace string"
                                                       int myNumber, // 101EAP1: CA "Check if parameter is out of range"
                                                       Country myCountry, // 101EAP1: CA "Check if enum parameter is defined by enum type"
                                                       List<string> moarStrings) // 101EAP1: CA "Check if parameter is an empty collection"
        {
            if (false)
            {
                TakeManyParametersAndCheckThemAll(" ", -10, (Country)3235, new List<string>());
            }
        }

        // 101EAP1: Inspection "Declaration is inferred to be not null" + QF
        private IEnumerable<string> ShowcaseAnnotations([ItemNotNull] List<string> strings, // 101EAP1: CAs to mark item nullability
                                                        [ItemCanBeNull] bool flag) // 101EAP1: Inspection "Container nullability attribute usage with declaration of non-container type" + QF
        {
            var badWord = "hell";
            foreach (var str in strings)
            {
                if (str.Contains(badWord))
                {
                    yield return str.Replace(badWord, "****");
                }
            }
        }
    }

    public enum Country
    {
        USA = 0,
        UK = 1,
        Germany = 2
    }

    // 101EAP1: CA "Create another part of the type"
    public class Feature
    {
        public string Name { get; set; }

        // 101EAP1: Invert boolean member (via Refactor This)
        public bool Unavailable { get; set; }
    }
}

// TODO: For JSON support, see MusicStore
