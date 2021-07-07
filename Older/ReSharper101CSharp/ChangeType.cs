using System.Collections;
using System.Collections.Generic;

namespace ReSharper101CSharp
{
    public class ChangeType
    {
         // 20161RTM: Cleaner highlighting of type mismatch (provided that "Suppress Visual Studio squiggles" is on in ReSharper settings) and more available QFs (caret at <decimal>)
         public IFilteredCollection<string, IEnumerable<double>> Field = new CollectionWithDefaultFilter<List<decimal>>();
    }

    public interface IFilteredCollection<TFilter, out TElement> : IEnumerable<TElement> { }

    public class FilteredCollection<TFilter, TElement> : IFilteredCollection<TFilter, TElement>
    {
        public IEnumerator<TElement> GetEnumerator() { throw new System.NotImplementedException(); }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

    public class CollectionWithDefaultFilter<TElement> : FilteredCollection<string, TElement> { }
    
}