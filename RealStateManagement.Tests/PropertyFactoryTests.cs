using RealStateManagement.Properties;
using RealStateManagement.Strategies;

namespace RealStateManagement.Tests
{
    public class PropertyFactoryTests
    {
        [Fact]
        public void Create_ShouldCreateApartament_AsExpected()
        {
            //Action
            var result = PropertyFactory.Create(PropertyType.Apartment, 100, 2, new StandardRentStrategy(), 4);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<Apartment>(result);
        }

        [Fact]
        public void Create_ShouldCreateHouse_AsExpected()
        {
            //Action
            var result = PropertyFactory.Create(PropertyType.House, 100, 2, new StandardRentStrategy(), true);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<House>(result);
        }

        [Fact]
        public void Create_ShouldCreateOffice_AsExpected()
        {
            //Action
            var result = PropertyFactory.Create(PropertyType.Office, 100, 2, new StandardRentStrategy(), 10);

            //Assert
            Assert.NotNull(result);
            Assert.IsType<OfficeSpace>(result);
        }

        [Fact]
        public void Create_ShouldThrowNotSupportedException_WhenInvalidPropertyTypeIsProvided()
        {
            //Action
            var act = () => PropertyFactory.Create((PropertyType)4, 100, 2, new StandardRentStrategy(), 10);

            //Assert
            Assert.Throws<NotSupportedException>(act);
        }
    }
}
