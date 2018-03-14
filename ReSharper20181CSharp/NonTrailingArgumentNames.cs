using System;
using System.Threading;
using System.Threading.Tasks;
// ReSharper disable UnusedVariable
// ReSharper disable UnusedMember.Global

namespace ReSharper20181CSharp
{
    public class NonTrailingArgumentNames
    {
        public static void Init(CancellationToken cancellationToken, Task task1, Task task2)
        {
            // Before C# 7.2
            var type = Type.GetType("MyNamespace.MyType", throwOnError: true, ignoreCase: true);
            //var delay3 = Task.Delay(millisecondsDelay: 1000, cancellationToken); // illegal: named argument cannot preced positional

            // With/after C# 7.2
            var delay = Task.Delay(millisecondsDelay: 1000, cancellationToken); // became legal
            //var delay2 = Task.Delay(cancellationToken, millisecondsDelay: 1000); // illegal: out-of-position

            When(all: TaskStatus.RanToCompletion, any: TaskStatus.Faulted, task1, task2); // became legal
            //When(all: TaskStatus.RanToCompletion, any: TaskStatus.Faulted, tasks: task1, task2); // still illegal

            //dynamic range = null;
            //range.Insert(shift: 0, "osdjfoi"); // error: named arguments cannot preced positional in dynamic invocation
        }

        public static Task When(TaskStatus all, TaskStatus any, params Task[] tasks)
            => throw new NotImplementedException();
    }
}
