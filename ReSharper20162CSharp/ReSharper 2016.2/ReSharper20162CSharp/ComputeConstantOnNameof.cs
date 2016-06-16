using System;

namespace ReSharper20162CSharp.ReSharper_2016._2.ReSharper20162CSharp
{
    public class ComputeConstantOnNameof
    {
        public string GetName()
        {
            // Place caret on `nameof`, Alt+Enter and "Compute constant value"
            return nameof(ComputeConstantOnNameof);
        }
    }
}