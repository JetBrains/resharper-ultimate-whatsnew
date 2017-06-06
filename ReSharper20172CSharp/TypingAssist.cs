namespace ReSharper20172CSharp
{
    public class TypingAssist
    {
        // Typing assist:
        // Type ! after string! and see [NotNull] is added.
        // Type ? after string? and see [CanNotBeNull] is added.
        public string SayHello(string name)
        {
            return "Hi, " + name;
        }

        // Typing assist:
        // Type { after => and see expression bodied member becomes block.
        public int DoubleTheValue(int someValue) => someValue * 2;
    }
}