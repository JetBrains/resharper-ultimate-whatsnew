#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

namespace ReSharper20212CSharp.NullableReferenceTypes.JetBrainsAnnotations
{
    // Migrate to nullable reference types
    // 1. Uncomment this
    //#nullable enable 

    public class Migration
    {
        // 2. Alt+Enter, use type annotation syntax -> in file
        [CanBeNull]
        public Person Find([NotNull, ItemCanBeNull] List<Person> employees, string name)
        {
            return employees.Single(x => x?.Name == name);
        }
    }
}