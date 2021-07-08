using Microsoft.CodeAnalysis;

namespace AutoNotifyGenerator
{
  [Generator]
  class DaemonGenerator : ISourceGenerator
  {
    public void Initialize(GeneratorInitializationContext context)
    {
    }

    public void Execute(GeneratorExecutionContext context)
    {
      context.AddSource("Person.cs",
        @"
public record Person(string Name, int Age, string JobTitle)
{
  public void SayHello() => System.Console.WriteLine($""Hi, I'm {Name}!"");
}");

      context.AddSource("DaemonDemo.cs",
        @"
public class GeneratedFileDaemon
{
  public static Person CreatePerson(string name, int age)
  {
    name ??= GetDefaultName();
    Person person = new(name, age, ""Developer advocate"");
    person.SayHello();
    return person;
  }

  public static string GetDefaultName() => ""John Doe"";
}");
    }
  }
}
