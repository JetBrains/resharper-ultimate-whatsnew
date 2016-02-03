using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }

    public class Feature
    {
        public string Name { get; set; }

        // UPDATE: Invert boolean member (via Refactor This)
        public bool Unavailable { get; set; }
    }

    // UPDATE: CA "Specify enum member values"
    enum Countries
    {
        USA,
        UK,
        Germany,
        Canada,
        France,
        Spain,
        Japan,
        Russia,
        China,
        Brazil
    }
}

// TODO: For JSON support, see MusicStore
