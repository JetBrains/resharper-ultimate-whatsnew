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
