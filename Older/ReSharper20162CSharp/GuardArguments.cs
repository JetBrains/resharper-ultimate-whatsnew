using System;

namespace ReSharper20162CSharp
{
    public class GuardArguments
    {
        // 20162RTM: Alt+Enter on parameter "Check parameter for null", expand to check all parameters at once
        public void NullGuardForAllArguments(int? intValue, string stringValue, object o, int notNull)
        {
        }
    }
}
