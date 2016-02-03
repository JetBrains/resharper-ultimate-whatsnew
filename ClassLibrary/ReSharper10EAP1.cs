using System.Collections.Generic;
using JetBrains.Annotations;

// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Local

namespace ClassLibrary
{
    public class ReSharper10EAP1
    {
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

        private static void ShowcaseInvertBoolean()
        {
            var feature = new Feature
            {
                Unavailable = false,
                Name = "Invert Boolean Member"
            };
        }

        private void TakeManyParametersAndCheckThemAll(string myString, // UPDATE: CA "Check parameter for null or empty/whitespace string"
                                                       int myNumber, // UPDATE: CA "Check if parameter is out of range"
                                                       Country myCountry, // UPDATE: CA "Check if enum parameter is defined by enum type"
                                                       List<string> moarStrings) // UPDATE: CA "Check if parameter is an empty collection"
        {
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
