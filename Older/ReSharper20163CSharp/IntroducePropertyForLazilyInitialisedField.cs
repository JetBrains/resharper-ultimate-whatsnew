using System;
// ReSharper disable UnusedMember.Global

namespace ReSharper20163CSharp
{
  public class IntroducePropertyForLazilyInitialisedField
  {
    // Introduce property for lazily initialised field
    //
    // Alt+Enter and select "Introduce property for lazily initialized field
    // Introduces a property to make the field easier to use - just use the property
    // instead of calling _foo.Value


    private readonly Lazy<string> _foo = new Lazy<string>(() => "Hello world");
  }
}