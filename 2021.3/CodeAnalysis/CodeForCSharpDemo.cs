namespace DemoProject;
#nullable enable
public class CodeForCSharpDemo
{
    //Paste this method to the CSharpDemo class
    public string? FindFirstElement(IEnumerable<string?> collection, string? filterParam, Func<string?, string?, bool> predicate)
    {
        foreach (var element in collection)
        {
            if (predicate(element, filterParam))
                return element;
        }

        return null;
    }
}