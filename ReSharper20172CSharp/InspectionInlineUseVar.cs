// ReSharper disable UnusedVariable

namespace ReSharper20172CSharp
{
    public class InspectionInlineUseVar
    {
        public void OutVarToType()
        {
            // Use context action to change out var to specify type directly
            var value = "42";
            if (int.TryParse(value, out var result))
            {
                // ...
            }
        }

        public void OutTypeToVar()
        {
            // Use context action to change out int to use var
            var value = "42";
            if (int.TryParse(value, out int result))
            {
                // ...
            }
        }
    }
}