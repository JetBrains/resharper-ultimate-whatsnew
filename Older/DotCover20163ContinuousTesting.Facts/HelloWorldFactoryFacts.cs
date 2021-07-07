using Xunit;

namespace CTDemo.Facts
{
    public class HelloWorldFactoryFacts
    {
        [Fact]
        public void ReturnsHelloWorld()
        {
            // Arrange
            var target = new HelloWorldFactory();

            // Act
            var result = target.Create();

            // Assert
            Assert.IsType<DefaultHelloWorld>(result);
        }
    }
}