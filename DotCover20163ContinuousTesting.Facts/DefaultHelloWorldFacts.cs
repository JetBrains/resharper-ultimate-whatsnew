using Xunit;

namespace CTDemo.Facts
{
    public class DefaultHelloWorldFacts
    {
        [Fact]
        public void ReturnsHelloWorld()
        {
            // Arrange
            var target = new DefaultHelloWorld(
                new DefaultHelloWorldMessageProvider());

            // Act
            var result = target.Execute();

            // Assert
            Assert.Equal("Hello, world!", result);
        }
    }
}