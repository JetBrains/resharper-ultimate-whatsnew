using System;

namespace ReSharper20172CSharp
{
    public interface IReturnReference
    {
        ref int GetReference();
    }

    public class RefReturn : IReturnReference
    {
        public int GetReference() => throw new NotImplementedException();
    }
}