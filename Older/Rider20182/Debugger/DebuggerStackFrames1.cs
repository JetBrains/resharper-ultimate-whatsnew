using System;

namespace Rider20182
{
    internal class DebuggerStackFrames1
    {
        // Improved presentation of stack frames (.ctor -> new T, .cctor -> static T, generic types with actual substitution) RIDER-11187 

        static DebuggerStackFrames1()
        {
            new DebuggerStackFrames1();
        }

        public DebuggerStackFrames1()
        {
            Run(null);
        }

        public static void Run(string[] args)
        {
            new MyClass1<int, int>().DoSomething();
        }

        public static void SomeMethod<TValue1, TValue2, TValue3>()
        {
            SomeMethod<int, int>();
        }

        public static void SomeMethod<TValue1, TValue2>()
        {
            // Place breakpoint here, and compare call stack with previous versions
            Console.WriteLine();
        }
    }
    internal class MyClass1<TKey, TValue>
    {
        public void DoSomething()
        {
            DebuggerStackFrames1.SomeMethod<int, int, int>();
        }
    }
}