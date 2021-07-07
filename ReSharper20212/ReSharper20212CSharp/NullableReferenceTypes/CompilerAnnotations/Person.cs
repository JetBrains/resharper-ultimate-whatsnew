#pragma warning disable 8618
// ReSharper disable UnusedMember.Global

using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;

#nullable enable

namespace ReSharper20212CSharp.NullableReferenceTypes.CompilerAnnotations
{
    // Alt+Enter on [AllowNull], remove redundant attribute
    // Alt+Enter on [NotNull], remove redundant attribute
    public class Person
    {
        [AllowNull] public Person? Parent { get; set; }
        [NotNull] public string Name { get; set; }
    }
}
