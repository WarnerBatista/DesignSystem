using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Strategies
{
    public class StandardRentStrategyTests
    {
        [Theory]
        [InlineData(0, 50, 0)]
        [InlineData(100, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 50, 5000)]
        [InlineData(100.00, 50.00, 5000.00)]
        [InlineData(120, 50, 6000)]
        [InlineData(120, 70, 8400)]
        public void Calculate_ShouldReturn_AsExpected(double basePrice, double size, double expectedValue)
        {
            //Arrange
            var sut = new StandardRentStrategy();

            //Action
            var result = sut.Calculate(basePrice, size);

            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}
