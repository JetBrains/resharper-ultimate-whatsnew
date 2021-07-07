namespace CTDemo
{
    public class DefaultHelloWorldMessageProvider
        : IHelloWorldMessageProvider
    {
        public string GetMessage()
        {
            return "Hello, world!";
        }
    }
}
