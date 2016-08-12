using System;
using System.Diagnostics.CodeAnalysis;

namespace ReSharper20162CSharp
{
  [SuppressMessage("ReSharper", "ArrangeTypeMemberModifiers")]
  class VerbatimInterpolation
  {

    //20162EAP8: Auto-correction of @$ in vebatim string

    void Foo(string name)
    {
      Console.WriteLine($@"Hello {name}");
    }
  }
}
