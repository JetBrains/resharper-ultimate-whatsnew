using System.Collections.Generic;
// ReSharper disable CollectionNeverUpdated.Local

namespace ReSharper20173CSharp.Deconstructors
{
    public static class KeyValuePairExtensions
    {
        public static void Deconstruct<TKey, TValue>(
            this KeyValuePair<TKey, TValue> pair,
            out TKey key, out TValue value)
        {
            key = pair.Key;
            value = pair.Value;
        }
    }

    public class FindUsagesDeconstructor
    {
        /// In <see cref="KeyValuePairExtensions.Deconstruct"/>, use Navigate To (Alt+`) to find usages of the extension method.

        public void Usage1()
        {
            var dictionary = new Dictionary<string, string>();
            foreach (var (key, value) in dictionary)
            {
                // do something
            }
        }

        public void Usage2(Dictionary<string, int> dictionary)
        {
            foreach (var (key, value) in dictionary)
            {
                // do something
            }
        }
    }
}