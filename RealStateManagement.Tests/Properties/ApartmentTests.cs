using NSubstitute;
using RealStateManagement.Properties;
using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Properties
{
    public class ApartmentTests
    {
        [Theory]
        [InlineData(0, 50, 4, 0, 8)]
        [InlineData(100, 0, 10, 0, 20)]
        [InlineData(0, 0, 7, 0, 14)]
        [InlineData(100, 50, 9, 4000, 4018)]
        [InlineData(100.00, 50.00, 2, 4000.00, 4004.00)]
        [InlineData(120, 50, 100, 4800, 5000)]
        [InlineData(120, 70, 20, 6720, 6760)]
        public void CalculateRent_ShouldReturn_AsExpected(double basePrice,
                                                          double size,
                                                          int floorNumber,
                                                          double expectedDiscountRentValue,
                                                          double expectedValue)
        {
            // Arrange
            var rentStrategy = Substitute.For<IRentStrategy, DiscountRentStrategy>();
            rentStrategy.Calculate(basePrice, size).Returns(expectedDiscountRentValue);

            var sut = new Apartment(basePrice, size, rentStrategy, floorNumber);

            // Act
            var rent = sut.CalculateRent();

            Assert.Equal(expectedValue, rent);
            rentStrategy.Received(1).Calculate(basePrice, size);
        }
    }
}
