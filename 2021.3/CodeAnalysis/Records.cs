// ReSharper disable once CheckNamespace
// ReSharper disable UnusedType.Global
namespace CSCodeAnalysis.Records;

class Code
{
    void Example()
    {
        // 1. Alt+Enter on Person, change to constructor
        var person = new Person { Name = "Maarten", Age = "37" };
    }
}

// 2. Alt+Enter on class, make record
public class Person
{
    // 3. Remove unused constructor
    // 4. Make primary constructor
    // 5. Change properties to init accessor (on set)
    // 6. Remove explicit properties
    public string Name { get; set; }
    public string Age { get; set; }
}