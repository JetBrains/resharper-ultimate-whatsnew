using Xunit;

namespace CTDemo.Facts
{
    public class DefaultHelloWorldMessageProviderFacts
    {
        [Fact]
        public void ReturnsHelloWorldMessage()
        {
            // Arrange
            var target = new DefaultHelloWorldMessageProvider();

            // Act
            var result = target.GetMessage();

            // Assert
            Assert.Equal("Hello, world!", result);
        }
    }
}
