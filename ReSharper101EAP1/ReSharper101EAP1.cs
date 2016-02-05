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
        // UPDATE: CAs to split or join attribute sections
        [ItemNotNull, AssertionMethod]
        [ItemCanBeNull]
        [AspDataField]
        public IEnumerable<string> ProcessEnumerable(IEnumerable<string> items)
        {
            // UPDATE: LINQ transformation suggestions are now downgraded to HINT severity
            foreach (var item in items)
            {
                if (item.EndsWith("suffix"))
                {
                    yield return item;
                }
            }
        }


        // creator.Create<Creation>(c => c.Nonsense = new A<B<C<D>>>().GetHashCode() >= 0 && true.CompareTo(false) <= 0);
        // UPDATE: Smart Paste (result of smart pasting the code snippet shown above into an XML doc comment)
        /// <summary>
        /// Contains use cases for Smart Paste feature
        /// </summary>
        /// <example>creator.Create&lt;Creation&gt;(c =&gt; c.Nonsense = new A&lt;B&lt;C&lt;D&gt;&gt;&gt;().GetHashCode() &gt;= 0 &amp;&amp; true.CompareTo(false) &lt;= 0);</example>
        private void ShowcaseSmartPasteInCSharp()
        {
            /*
               var p = Test();
               var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'
            */
            // UPDATE: Smart Paste (result of smart pasting the code snippet shown above)
            var pastedCodeSnippet = "var p = Test();\r\n                var s = p.ToString(); // Warning: Possible \'System.NullReferenceException\'";

            // UPDATE: Smart Paste (result of smart pasting string literal from a regular string literal (pastedCodeSnippet) to a verbatim string literal)
            var pastedFromRegularToVerbatim = @"var p = Test();
                var s = p.ToString(); // Warning: Possible 'System.NullReferenceException'";

            // <member name="T:JetBrains.Annotations.NotNullAttribute">
            // UPDATE: Smart Paste (result of smart pasting the XML snippet shown above)
            var pastedXmlSnippet = "<member name=\"T:JetBrains.Annotations.NotNullAttribute\">";

            // C:\nameOfFolder
            // UPDATE: Smart Paste (result of smart pasting the path shown above)
            var pastedWindowsPath = "C:\\nameOfFolder";
        }

        private void ShowcaseStringActions(string input)
        {
            // UPDATE: Inspection "Redundant string verbatimity sign" + QF
            string s = $@"{input} yo";

            // UPDATE: Inspection "Redundant verbatim identifier" + QF
            string @from = input;

            // UPDATE: CA "Use String.Equals() method"
            var areEqual = "a" == "A";
        }

        private void ShowcaseCSharp6(string input)
        {
            // UPDATE: CA "Convert string interpolation into string.Format"
            string firstString = $"{input} yay";

            // UPDATE: CA "Convert concatenation to interpolation"
            string secondString = "Here's my input: " + input;

            // UPDATE: Refactoring "Introduce variable for substring" supports string interpolation
            string thirdString = string.Concat($"Here\'s my input: {input}");

            // UPDATE: Inspection "Nested string interpolation can be inlined" + QF
            string fourthString = $"{ $"{input} yay"}";

        }

        private static void ShowcaseInvertBoolean()
        {
            var feature = new Feature
            {
                Unavailable = false,
                Name = "Invert Boolean Member"
            };

            // UPDATE: CA "Comment/Uncomment code" (commenting is only available on selection)
/*
            var anotherFeature = new Feature
            {
                Unavailable = true,
                Name = "Comment selection"
            };
*/
        }

        private void TakeManyParametersAndCheckThemAll(string myString, // UPDATE: CA "Check parameter for null or empty/whitespace string"
                                                       int myNumber, // UPDATE: CA "Check if parameter is out of range"
                                                       Country myCountry, // UPDATE: CA "Check if enum parameter is defined by enum type"
                                                       List<string> moarStrings) // UPDATE: CA "Check if parameter is an empty collection"
        {
            if (false)
            {
                TakeManyParametersAndCheckThemAll(" ", -10, (Country)3235, new List<string>());
            }
        }

        // UPDATE: Inspection "Declaration is inferred to be not null" + QF
        private IEnumerable<string> ShowcaseAnnotations([ItemNotNull] List<string> strings, // UPDATE: CAs to mark item nullability
                                                        [ItemCanBeNull] bool flag) // UPDATE: Inspection "Container nullability attribute usage with declaration of non-container type" + QF
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

    // UPDATE: CA "Create another part of the type"
    public class Feature
    {
        public string Name { get; set; }

        // UPDATE: Invert boolean member (via Refactor This)
        public bool Unavailable { get; set; }
    }
}

// TODO: For JSON support, see MusicStore
