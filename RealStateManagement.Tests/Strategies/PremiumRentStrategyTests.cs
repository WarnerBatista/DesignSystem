using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Strategies
{
    public class PremiumRentStrategyTests
    {
        [Theory]
        [InlineData(0, 50, 0)]
        [InlineData(100, 0, 0)]
        [InlineData(0, 0, 0)]
        [InlineData(100, 50, 7500)]
        [InlineData(100.00, 50.00, 7500.00)]
        [InlineData(120, 50, 9000)]
        [InlineData(120, 70, 12600)]
        public void Calculate_ShouldReturn_AsExpected(double basePrice, double size, double expectedValue)
        {
            //Arrange
            var sut = new PremiumRentStrategy();

            //Action
            var result = sut.Calculate(basePrice, size);

            //Assert
            Assert.Equal(expectedValue, result);
        }
    }
}
