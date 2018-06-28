using System;
using System.Threading.Tasks;

namespace Rider20182
{
    internal class DebuggerStackFrames2
    {
        static DebuggerStackFrames2()
        {
            new DebuggerStackFrames2();
        }

        public DebuggerStackFrames2()
        {
            Run(null);
        }

        public static void Run(string[] args)
        {
            new MyClass2<int, short>().DoSomething();
        }

        public static void SomeMethod<TValue1, TValue2, TValue3>()
        {
            SomeMethod<char, bool>();
        }

        public static void SomeMethod<TValue1, TValue2>()
        {
            new MyClass2<string, double>().AsyncMethod<float, long>(1, 2).Wait();
        }
    }

    internal class MyClass2<TKey, TValue>
    {
        public void DoSomething()
        {
            DebuggerStackFrames2.SomeMethod<decimal, byte, uint>();
        }

        public async Task<int> AsyncMethod<TFirst, TSecond>(int a, int b)
        {
            await AsyncWaiter<ushort>();
            return 1;
        }

        public async Task AsyncWaiter<TValue>()
        {
            await Task.Delay(100);
            // Place breakpoint here, and compare call stack with previous versions
            Console.WriteLine();
        }
    }
}