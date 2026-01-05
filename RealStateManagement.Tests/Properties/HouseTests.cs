using NSubstitute;
using RealStateManagement.Properties;
using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Properties
{
    public class HouseTests
    {
        [Theory]
        [InlineData(0, 50, true, 0, 50)]
        [InlineData(100, 0, false, 0, 0)]
        [InlineData(0, 0, true, 0, 50)]
        [InlineData(100, 50, false, 4000, 4000)]
        [InlineData(100.00, 50.00, true, 4000.00, 4050.00)]
        [InlineData(120, 50, false, 4800, 4800)]
        [InlineData(120, 70, true, 6720, 6770)]
        public void CalculateRent_ShouldReturn_AsExpected(double basePrice,
                                                          double size,
                                                          bool hasGarden,
                                                          double expectedDiscountRentValue,
                                                          double expectedValue)
        {
            //Arrange
            var rentStrategy = Substitute.For<IRentStrategy, DiscountRentStrategy>();
            rentStrategy.Calculate(basePrice, size).Returns(expectedDiscountRentValue);

            var sut = new House(basePrice, size, rentStrategy, hasGarden);

            //Act
            var result = sut.CalculateRent();

            //Assert
            Assert.Equal(expectedValue, result);
            rentStrategy.Received(1).Calculate(basePrice, size);
        }
    }
}
