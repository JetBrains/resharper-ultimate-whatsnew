using System.Collections.Generic;
using JetBrains.Annotations;
#pragma warning disable 219

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local

namespace ReSharper101CSharp
{
    public class Miscellaneous
    {
        // 20161RTM: CAs to split or join attribute sections
        [ItemNotNull, AssertionMethod]
        [ItemCanBeNull]
        [AspDataField]
        public IEnumerable<string> ProcessEnumerable(IEnumerable<string> items)
        {
            // 20161RTM: LINQ transformation suggestions are now downgraded to HINT severity
            foreach (var item in items)
            {
                if (item.EndsWith("suffix"))
                {
                    yield return item;
                }
            }
        }

        private static void ShowcaseInvertBoolean()
        {
            var feature = new Feature
            {
                Unavailable = false,
                Name = "Invert Boolean Member"
            };

            // 20161RTM: CA "Comment/Uncomment code" (commenting is only available on selection)
            /*
                        var anotherFeature = new Feature
                        {
                            Unavailable = true,
                            Name = "Comment selection"
                        };
            */
        }
    }

    public enum Country
    {
        USA = 0,
        UK = 1,
        Germany = 2
    }

    // 20161RTM: CA "Create another part of the type"
    public class Feature
    {
        public string Name { get; set; }

        // 20161RTM: Invert boolean member (via Refactor This)
        public bool Unavailable { get; set; }
    }
}

// TODO: For JSON support, see MusicStore
