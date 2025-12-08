using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Strategies
{
    public class DiscountRentStrategyTests
    {
        [Theory]
        [InlineData(0, 50, 0)]
        [InlineData(100, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 50, 4000)]
        [InlineData(100.00, 50.00, 4000.00)]
        [InlineData(120, 50, 4800)]
        [InlineData(120, 70, 6720)]
        public void Calculate_ShouldReturn_AsExpected(double basePrice, double size, double expectedValue)
        {
            //Arrange
            var sut = new DiscountRentStrategy();

            //Action
            var result = sut.Calculate(basePrice, size);

            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}
