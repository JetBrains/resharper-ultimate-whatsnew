namespace ReSharper20172CSharp
{
    public class InspectionInheritDoc
    {
        // 1. Inspection will show <inheritdoc /> is invalid (multiple base candidates).
        // 2. Invoke quick-fix (Alt+Enter) to specify base to inherit documentation from.
        /// <inheritdoc />
        public class TenantAwareCustomerRepository
            : ITenantAware, IRepository<Customer>
        {
        }

        // 3. Inspection will show we are overriding base documentation.
        // 4. Quick-fix (Alt+Enter) lets us add <inheritdoc />
        /// <summary>
        /// Customer repository.
        /// </summary>
        public class CustomerRepository
            : IRepository<Customer>
        {
        }

        #region Infrastructure

        /// <summary>
        /// Makes the implementation a repository for instances of type <typeparamref name="T"/>.
        /// </summary>
        /// <typeparam name="T">Repository type.</typeparam>
        public interface IRepository<T>
        {
        }

        /// <summary>
        /// Marks the implementation as tenant-aware.
        /// </summary>
        public interface ITenantAware
        {
        }

        #endregion
    }
}