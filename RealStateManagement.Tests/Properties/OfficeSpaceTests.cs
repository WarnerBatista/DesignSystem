using NSubstitute;
using RealStateManagement.Properties;
using RealStateManagement.Strategies;

namespace RealStateManagement.Tests.Properties
{
    public class OfficeSpaceTests
    {
        [Theory]
        [InlineData(0, 50, 4, 0, 20)]
        [InlineData(100, 0, 10, 0, 50)]
        [InlineData(0, 0, 7, 0, 35)]
        [InlineData(100, 50, 9, 4000, 4045)]
        [InlineData(100.00, 50.00, 2, 4000.00, 4010.00)]
        [InlineData(120, 50, 100, 4800, 5300)]
        [InlineData(120, 70, 20, 6720, 6820)]
        public void CalculateRent_ShouldReturn_AsExpected(double basePrice,
                                                          double size,
                                                          int numberOfDesks,
                                                          double expectedDiscountRentValue,
                                                          double expectedValue)
        {
            // Arrange
            var rentStrategy = Substitute.For<IRentStrategy, DiscountRentStrategy>();
            rentStrategy.Calculate(basePrice, size).Returns(expectedDiscountRentValue);

            var sut = new OfficeSpace(basePrice, size, rentStrategy, numberOfDesks);

            // Act
            var result = sut.CalculateRent();

            // Assert
            Assert.Equal(expectedValue, result);
            rentStrategy.Received(1).Calculate(basePrice, size);
        }
    }
}
