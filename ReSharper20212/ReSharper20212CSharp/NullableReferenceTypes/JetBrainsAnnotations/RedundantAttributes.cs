#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using JetBrains.Annotations;

#nullable enable

namespace ReSharper20212CSharp.NullableReferenceTypes.JetBrainsAnnotations
{
    public class RedundantAttributes
    {
        // Alt+Enter on both attributes, see they are redundant as info is already available
        [NotNull] public string Name { get; set; }

        [ItemCanBeNull] public List<string?> Emails { get; set; }
    }
}