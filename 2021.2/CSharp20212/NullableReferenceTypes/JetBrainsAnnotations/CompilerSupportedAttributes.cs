#pragma warning disable 8618
#pragma warning disable 693
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedMember.Local

using System.Collections.Generic;
using System.Linq;
using JetBrains.Annotations;

// 1. Uncomment this
// #nullable enable

namespace CSharp20212.NullableReferenceTypes.JetBrainsAnnotations
{
    public class Cache<TKey, TValue> : ICache
        where TKey : notnull
    {
        private readonly Dictionary<TKey, TValue> _store = new();

        // 2. Alt+Enter, Use compiler attributes in GetValueOrDefault
        //    See return: statement pop up
        //    See DisallowNull on defaultValue argument
        //
        // 3. Alt+Enter on [CanBeNull] TKey key, use type annotation syntax in class Cache
        //    See types are all updated, also where TValue : default added 
        [NotNull]
        public TValue GetValueOrDefault([CanBeNull] TKey key, [NotNull] TValue defaultValue)
        {
            return key != null && _store.TryGetValue(key, out var cachedValue)
                ? cachedValue
                : defaultValue;
        }

        [ItemCanBeNull]
        IEnumerable<TValue> ICache.EnumerateValuesOfType<TValue>()
            => _store.Values.OfType<TValue>();
    }

#nullable disable
    public interface ICache
    {
        [ItemCanBeNull]
        IEnumerable<TValue> EnumerateValuesOfType<TValue>();
    }
}