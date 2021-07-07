namespace CTDemo
{
    public class HelloWorldFactory
    {
        public IHelloWorld Create()
        {            
            return new DefaultHelloWorld(new DefaultHelloWorldMessageProvider());
        }
    }
}