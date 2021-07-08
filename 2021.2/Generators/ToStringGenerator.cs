using System;
using System.Collections.Immutable;
using System.Diagnostics;
using Microsoft.CodeAnalysis;

namespace Generators
{
  [Generator]
  class ToStringGenerator : ISourceGenerator
  {
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
      context.AddSource("Employee.cs",
        @"
using System;

namespace CSharp20212.SourceGenerators
{
  public partial class Employee
  {
    public override string ToString()
    {
      return $""{nameof(_firstName)}: {_firstName}, {nameof(_lastName)}: {_lastName}"";
    }
  }
}");
    }
  }
}
