using DesignPatternsExamples.Creational.Prototype.Models;
using DesignPatternsExamples.Creational.Prototype.Models.Customers;
using Xunit;

namespace DesignPatternsTests.Creational.Prototype
{
    public class PrivateCustomerTests
    {
        [Fact]
        public void PrivateCustomer_DeepClone_ShouldReturnObjectOfPrivateCustomerType()
        {
            //Arrange
            PrivateCustomer _uut = new PrivateCustomer();

            //Act
            var deepCopy = _uut.DeepClone();

            //Assert
            Assert.NotNull(deepCopy);
            Assert.IsType<PrivateCustomer>(deepCopy);
        }

        [Fact]
        public void PrivateCustomer_DeepClone_ShouldProperlyCloneObjectValues()
        {
            //Arrange
            string ExpectedName = "Adrian";
            string ExpectedSurname = "Krasowski";
            string ExpectedStreetName = "Street";
            string ExpectedCityName = "City";
            string ExpectedCountryName = "Country";
            bool ExpectedAdulthood = true;

            Address ExpectedAddress = new Address()
            {
                Street = ExpectedStreetName,
                City = ExpectedCityName,
                Country = ExpectedCountryName
            };
            PrivateCustomer _uut = new PrivateCustomer()
            {
                Name = ExpectedName,
                Surname = ExpectedSurname,
                IsLegallyAdult = ExpectedAdulthood,
                Address = ExpectedAddress
            };

            //Act
            var deepCopy = _uut.DeepClone() as PrivateCustomer;

            //Assert
            Assert.Equal(ExpectedName, deepCopy.Name);
            Assert.Equal(ExpectedSurname, deepCopy.Surname);
            Assert.Equal(ExpectedAdulthood, deepCopy.IsLegallyAdult);
            Assert.Equal(ExpectedCityName, deepCopy.Address.City);
            Assert.Equal(ExpectedStreetName, deepCopy.Address.Street);
            Assert.Equal(ExpectedCountryName, deepCopy.Address.Country);
        }

        [Fact]
        public void PrivateCustomer_DeepClone_ShouldCreateADeepCopy()
        {
            //Arrange
            string ExpectedName = "Adrian";
            string ExpectedSurname = "Krasowski";
            string ExpectedStreetName = "Street";
            string ExpectedCityName = "City";
            string ExpectedCountryName = "Country";
            bool ExpectedAdulthood = true;

            Address ExpectedAddress = new Address()
            {
                Street = ExpectedStreetName,
                City = ExpectedCityName,
                Country = ExpectedCountryName
            };
            PrivateCustomer _uut = new PrivateCustomer()
            {
                Name = ExpectedName,
                Surname = ExpectedSurname,
                IsLegallyAdult = ExpectedAdulthood,
                Address = ExpectedAddress
            };

            //Act
            var deepCopy = _uut.DeepClone() as PrivateCustomer;
            _uut.Address.Street = "OtherStreet";

            //Assert
            Assert.NotEqual(_uut.Address.Street, deepCopy.Address.Street);
            Assert.Equal(ExpectedStreetName, deepCopy.Address.Street);
            Assert.Equal(ExpectedName, deepCopy.Name);
            Assert.Equal(ExpectedSurname, deepCopy.Surname);
            Assert.Equal(ExpectedAdulthood, deepCopy.IsLegallyAdult);
            Assert.Equal(ExpectedCityName, deepCopy.Address.City);
            Assert.Equal(ExpectedCountryName, deepCopy.Address.Country);
        }

        [Fact]
        public void PrivateCustomer_ShallowClone_ShouldReturnObjectOfPrivateCustomerType()
        {
            //Arrange
            PrivateCustomer _uut = new PrivateCustomer();

            //Act
            var deepCopy = _uut.ShallowClone();

            //Assert
            Assert.NotNull(deepCopy);
            Assert.IsType<PrivateCustomer>(deepCopy);
        }

        [Fact]
        public void PrivateCustomer_ShallowClone_ShouldProperlyCloneObjectValues()
        {
            //Arrange
            string ExpectedName = "Adrian";
            string ExpectedSurname = "Krasowski";
            string ExpectedStreetName = "Street";
            string ExpectedCityName = "City";
            string ExpectedCountryName = "Country";
            bool ExpectedAdulthood = true;

            Address ExpectedAddress = new Address()
            {
                Street = ExpectedStreetName,
                City = ExpectedCityName,
                Country = ExpectedCountryName
            };
            PrivateCustomer _uut = new PrivateCustomer()
            {
                Name = ExpectedName,
                Surname = ExpectedSurname,
                IsLegallyAdult = ExpectedAdulthood,
                Address = ExpectedAddress
            };

            //Act
            var deepCopy = _uut.ShallowClone() as PrivateCustomer;

            //Assert
            Assert.Equal(ExpectedName, deepCopy.Name);
            Assert.Equal(ExpectedSurname, deepCopy.Surname);
            Assert.Equal(ExpectedAdulthood, deepCopy.IsLegallyAdult);
            Assert.Equal(ExpectedCityName, deepCopy.Address.City);
            Assert.Equal(ExpectedStreetName, deepCopy.Address.Street);
            Assert.Equal(ExpectedCountryName, deepCopy.Address.Country);
        }

        [Fact]
        public void PrivateCustomer_ShallowClone_ShouldCreateAShallowCopy()
        {
            //Arrange
            string ExpectedName = "Adrian";
            string ExpectedSurname = "Krasowski";
            string NotExpectedStreetName = "Street";
            string ExpectedCityName = "City";
            string ExpectedCountryName = "Country";
            bool ExpectedAdulthood = true;

            Address ExpectedAddress = new Address()
            {
                Street = NotExpectedStreetName,
                City = ExpectedCityName,
                Country = ExpectedCountryName
            };
            PrivateCustomer _uut = new PrivateCustomer()
            {
                Name = ExpectedName,
                Surname = ExpectedSurname,
                IsLegallyAdult = ExpectedAdulthood,
                Address = ExpectedAddress
            };

            //Act
            var deepCopy = _uut.ShallowClone() as PrivateCustomer;
            _uut.Address.Street = "OtherStreet";

            //Assert
            Assert.Equal(_uut.Address.Street, deepCopy.Address.Street);
            Assert.NotEqual(NotExpectedStreetName, deepCopy.Address.Street);
            Assert.Equal(ExpectedName, deepCopy.Name);
            Assert.Equal(ExpectedSurname, deepCopy.Surname);
            Assert.Equal(ExpectedAdulthood, deepCopy.IsLegallyAdult);
            Assert.Equal(ExpectedCityName, deepCopy.Address.City);          
            Assert.Equal(ExpectedCountryName, deepCopy.Address.Country);
        }
    }
}
