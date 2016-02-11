using System.Collections.Generic;
using JetBrains.Annotations;
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

namespace ReSharper101CSharp
{
    public class NullabilityAnnotations
    {
        // 101EAP1: Inspection "Declaration is inferred to be not null" + QF
        private IEnumerable<string> ShowcaseAnnotations([ItemNotNull] List<string> strings, // 101EAP1: CAs to mark item nullability
                                                        [ItemCanBeNull] bool flag) // 101EAP1: Inspection "Container nullability attribute usage with declaration of non-container type" + QF
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