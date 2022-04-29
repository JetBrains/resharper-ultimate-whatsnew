#nullable enable

namespace CodeAnalysis.NullableReferenceTypes;


public static class WarningsMode
{
    public record Person(
        string Name,
        string? Email);

    public static void Example()
    {
        // When nullable annotations are enabled (#nullable enable),
        // code analysis trusts these by default.
        //
        // When a new Person is created in a consuming assembly without NRT enabled,
        // or when using the null-forgiving operator (!), you can still pass in a null value.
        //
        // The null check on "name" in CreatePerson should not be required, according to annotations.
        // 
        // You can configure ReSharper to be okay with these runtime checks,
        // even if annotations suggest these checks are redundant.
        //
        // This gives you the benefit of having annotations to help with consuming code and expectations,
        // while the author of the code that is being consumed can still make sure things are checked without
        // these "redundant check" warnings. The best of both worlds!
        //
        // ReSharper settings - Code Inspection | Settings
        // Nullable reference types' warnings mode
        // * Trust API contracts
        // * Trust only runtime checks
        // (or use the Alt+Enter toggle)

        var person = CreatePerson(null!, null);
        Console.WriteLine("Name: {0}", person.Name);
        Console.WriteLine("Email: {0}", person.Email);
    }

    public static Person CreatePerson(string name, string? email)
    {
        // Note that an ArgumentNullException.ThrowIfNull(name); is never considered redundant.
        if (name == null) // "Trust API contracts" -> redundant check; "Trust only runtime checks" -> this check is okay
        {
            return new Person("Unknown", email);
        }

        return new Person(name, null);
    }
}
