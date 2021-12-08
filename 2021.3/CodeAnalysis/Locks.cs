// ReSharper disable once CheckNamespace
// ReSharper disable UnusedType.Global
namespace CSCodeAnalysis;

class Locks
{
    private static readonly object Lock1 = new();
    private static readonly object Lock2 = new();

    public void SomeMethod1()
    {
        lock (Lock1)
        {
            // do things

            lock (Lock2)
            {
                // do other things
            }
        }
    }

    public void SomeMethod2()
    {
        lock (Lock2)
        {
            // do things
            SomeMethod3();
        }
    }

    private void SomeMethod3()
    {
        lock (Lock1)
        {
            // do things
        }
    }
}