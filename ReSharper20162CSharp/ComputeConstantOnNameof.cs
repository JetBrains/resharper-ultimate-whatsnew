namespace ReSharper20162CSharp
{
    public class ComputeConstantOnNameof
    {
        public string GetName()
        {
            // 20162RTM: Place caret on `nameof`, Alt+Enter and "Compute constant value"
            return nameof(ComputeConstantOnNameof);
        }
    }
}