using System;

namespace ReSharper20162CSharp
{
    // 20162RTM: Support for <inheritdoc/>

    /// <summary>
    /// This is a very useful interface.
    /// </summary>
    public interface IBaseDocumentedClass
    {
        /// <summary>
        /// This is a property.
        /// </summary>
        string Property { get; set; }

        /// <summary>
        /// This is also a property.
        /// </summary>
        string AnotherProperty { get; set; }
        
        /// <summary>
        /// This is a method.
        /// </summary>
        /// <param name="id">Long story short, this is an identifier.</param>
        void Execute(int id);

    }

    // QF "Implement missing members" (as well as Generate actions Missing members and Overriding members) will add <inheritdoc/>
    // because there's a shared solution setting to do that (ReSharper > Options > Code Editing > Members Generation > Generated documentation)
    /// <inheritdoc/>
    /// <remarks>This is also a useful class but it's a bit more documented</remarks>
    class DerivedInitiallyNonDocumentedClass : IBaseDocumentedClass
    {
        // Context action to add an <inheritdoc/> on property name
        public string Property { get; set; }

        // Quick Documentation on this implementation will show both inherited and overridden docs
        /// <inheritdoc />
        /// <remarks>This is not your usual method: it inherits documentation from its base via &lt;inheritdoc/&gt; and extends it by adding this remark.</remarks>
        public void Execute(int id)
        {
            throw new NotImplementedException();
        }
    }
}