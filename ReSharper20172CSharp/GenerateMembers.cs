namespace ReSharper20172CSharp
{
    public interface IPerson
    {
        string Name { get; }
    }
    
    public class GenerateMembers
        : IPerson
    {
        // Generate members can make read-only interface members mutable.
        // Alt+Insert to generate members, "Generate missing members",
        // tick "Make properties mutable"
        
    }
}