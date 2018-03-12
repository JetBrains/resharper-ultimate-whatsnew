using System;
using System.Threading;
using System.Threading.Tasks;
// ReSharper disable UnusedVariable

namespace ReSharper20181CSharp
{
    public class NonTrailingArgumentNames
    {
        public static void Init(CancellationToken cancellationToken)
        {
            var delay = Task.Delay(millisecondsDelay: 1000, cancellationToken);
            var type = Type.GetType("MyNamespace.MyType", throwOnError: true, ignoreCase: true);
        }
    }
}
