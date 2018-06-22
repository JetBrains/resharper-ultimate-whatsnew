namespace ReSharper20182CSharp
{
    public class UnsafeCodeCompletion
    {
        public struct Point
        {
            public int X, Y;

            public unsafe bool* HasCoordinates()
            {
                return null;
            }
        }
        
        public class Example
        {
            unsafe void Demo()
            {
                // TODO: NOT YET IN NIGHTLIES/EAP
                // https://twitter.com/kskrygan/status/1008734433451659264
                var point = new Point();
                var pointPointer = &point;
                //pointPointer.HasCoordinates();
                //pointPointer->HasCoordinates();
            }
        }
    }
}