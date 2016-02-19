using System.Collections;
using System.Collections.Generic;

namespace ReSharper101CSharp
{
    public class ChangeType
    {
         // 101EAP3: Cleaner highlighting of type mismatch and more available QFs
         public IFilteredCollection<string, IEnumerable<double>> Field = new CollectionWithDefaultFilter<List<decimal>>();

        void Method()
        {
            Field = new CollectionWithDefaultFilter<IEnumerable<decimal>>();
        }
    }

    public interface IFilteredCollection<TFilter, out TElement> : IEnumerable<TElement> { }

    public class FilteredCollection<TFilter, TElement> : IFilteredCollection<TFilter, TElement>
    {
        public IEnumerator<TElement> GetEnumerator() { throw new System.NotImplementedException(); }

        IEnumerator IEnumerable.GetEnumerator() { return GetEnumerator(); }
    }

    public class CollectionWithDefaultFilter<TElement> : FilteredCollection<string, TElement> { }
    
}