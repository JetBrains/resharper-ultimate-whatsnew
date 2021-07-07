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
                var point = new Point();
                var pointPointer = &point;                
                //pointPointer.HasCoordinates();
                //pointPointer->HasCoordinates();
            }
        }
    }
}