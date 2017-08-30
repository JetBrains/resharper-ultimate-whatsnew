using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

// ReSharper disable SuggestVarOrType_Elsewhere

namespace ReSharper20172CSharp
{
    public class InspectionPossibleMultipleEnumeration
    {
        public void PossibleMultipleEnumerationForIEnumerable()
        {
            IEnumerable<string> names = GetNames();
            foreach (var name in names) // 1. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                Console.WriteLine("Name: " + name);
            }

            var allNames = new StringBuilder();
            foreach (var name in names) // 2. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                allNames.AppendLine(name);
            }
        }

        public void PossibleMultipleEnumerationForIOrderedEnumerable()
        {
            IOrderedEnumerable<string> names = GetNames().OrderBy(n => n);
            foreach (var name in names) // 1. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                Console.WriteLine("Name: " + name);
            }

            var allNames = new StringBuilder();
            foreach (var name in names) // 2. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                allNames.AppendLine(name);
            }
        }

        public void PossibleMultipleEnumerationForParallelQuery()
        {
            ParallelQuery<string> names = GetNames().AsParallel();
            foreach (var name in names) // 1. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                Console.WriteLine("Name: " + name);
            }

            var allNames = new StringBuilder();
            foreach (var name in names) // 2. "names" shows inspection "Possible multiple enumeration of IEnumerable". Use quick-fix.
            {
                allNames.AppendLine(name);
            }
        }

        public IEnumerable<string> GetNames()
        {
            yield return "Maarten";
            yield return "Matt";
        }
    }
}