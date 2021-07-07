namespace CTDemo
{
    public class DefaultHelloWorld
        : IHelloWorld
    {
        private readonly IHelloWorldMessageProvider _helloWorldMessageProvider;

        public DefaultHelloWorld(IHelloWorldMessageProvider helloWorldMessageProvider)
        {
            _helloWorldMessageProvider = helloWorldMessageProvider;
        }

        public string Execute()
        {
            return _helloWorldMessageProvider.GetMessage();
        }
    }
}