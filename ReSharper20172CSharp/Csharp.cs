// ReSharper disable UnusedVariable
namespace ReSharper20172CSharp
{
    public class Csharp
    {
        public void OutVarToType()
        {
            // Use context action to change out var to specify type directly
            string value = "1";
            if (int.TryParse(value, out var result))
            {
                // ...
            }
        }

        public void OutTypeToVar()
        {
            // Use context action to change out int to use var
            string value = "1";
            if (int.TryParse(value, out int result))
            {
                // ...
            }
        }
    }
}