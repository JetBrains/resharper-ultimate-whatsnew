using System;
using System.Collections.Generic;
using System.Linq;

namespace ReSharper20182CSharp
{
    public class DeclarationExpressionsD
    {
        public IEnumerable<string> FilterPositiveNumbers1(IEnumerable<string> enumerable)
        {
            // Query expressions
            var result = from str in enumerable
                where int.TryParse(str, out var number) && number > 0
                select str;

            // Note that the scope of the introduced variable is limited to the containing query clause,
            // i.e. in the example above it won't be visible in the select clause, so select number will be invalid.
            // Doesn't work:
            //var result2 = from str in enumerable
            //    where int.TryParse(str, out var number) && number > 0
            //    select new
            //           {
            //               A = str,
            //               B = number // "number" is not available in this scope
            //           };

            return result;
        }

        public IEnumerable<object> FilterPositiveNumbers2(IEnumerable<object> enumerable)
        {
            return from obj in enumerable
                where obj is string s && s.Length > 0
                select obj;
        }
    }
}
