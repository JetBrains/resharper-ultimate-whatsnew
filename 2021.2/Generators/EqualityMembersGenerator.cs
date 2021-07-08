using Microsoft.CodeAnalysis;

namespace Generators
{
  [Generator]
  class EqualityMembersGenerator : ISourceGenerator
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
    protected bool Equals(Employee other)
    {
      return _firstName == other._firstName && _lastName == other._lastName;
    }
    
    public override bool Equals(object obj)
    {
      if (ReferenceEquals(null, obj))
        return false;
      if (ReferenceEquals(this, obj))
        return true;
      if (obj.GetType() != this.GetType())
        return false;
    
      return Equals((Employee)obj);
    }
    
    public override int GetHashCode()
    {
      return HashCode.Combine(_firstName, _lastName);
    }
  }
}");
    }
  }
}