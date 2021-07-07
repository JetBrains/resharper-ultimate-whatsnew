using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace ReSharper101CSharp
{
    public class NullabilityAnnotations
    {
        // 20161RTM: Inspection "Declaration is inferred to be not null" + QF
        private IEnumerable<string> ShowcaseAnnotations([ItemNotNull] List<string> strings, // 20161RTM: CAs to mark item nullability
                                                        [ItemCanBeNull] bool flag) // 20161RTM: Inspection "Container nullability attribute usage with declaration of non-container type" + QF
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
}