using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharper20172CSharp
{
    public static class InspectionPossiblyUnintendedTransformationOfIQueryable
    {
        public static void Example()
        {
            using (var databaseContext = new DatabaseContext())
            {
                // Objects that implement the IQueryable interface are meant to be processed by LINQ providers
                // (normally, remote databases) with their specific implementations of this interface.
                // However, as IQueryable is inherited from IEnumerable, there could be cases when an IQueryable 
                // object is passed and processed as an IEnumerable object, meaning that all processing is done on 
                // the local machine.Such implicit conversions are not a problem in test environments, but could 
                // make a huge performance impact in production.
                //
                // WhereNameStartsWith should show inspection:
                //    "IQueryable is possibly unintentionally used as IEnumerable".
                //
                // Invoke quick-fix to add .AsEnumerable(), making the conversion explicit.
                var names = databaseContext.Names.WhereNameStartsWith("M");
            }
        }

        public static IEnumerable<string> WhereNameStartsWith(this IEnumerable<string> items, string startsWith)
        {
            return items.Where(item => item.StartsWith(startsWith, StringComparison.OrdinalIgnoreCase));
        }

        public class DatabaseContext : IDisposable
        {
            public IQueryable<string> Names => new List<string> {"Maarten", "Matt", "Hadi"}.AsQueryable();

            public void Dispose()
            {
            }
        }
    }
}