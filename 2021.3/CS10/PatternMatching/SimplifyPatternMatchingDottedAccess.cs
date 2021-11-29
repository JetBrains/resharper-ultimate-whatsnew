namespace CS10.PatternMatching;

public class SimplifyPatternMatchingDottedAccess
{
    public void Demo()
    {

        var user1 = new User();
        if (user1 is { Tags.Count: 0 }) // CA "Split into nested patterns" over dot
        {
            // ...
        }




        var user = new User();
        if (user is { Tags: { Count: 0 } }) 
        {
            // ...
        }
    }

    public class User
    {
        public List<string> Tags { get; } = new();
    }
}
