using Xunit;
using DesignPatternsExamples.Creational.Builder.Directors;
using System;
using DesignPatternsExamples.Creational.Builder.Builders;

namespace DesignPatternsTests.Creational.Builder.Directors
{
    public class AccountWithAddressDirectorTests
    {
        [Fact]
        public void AccountWithAddressDirector_ShouldThrowInvalidOperationException_IfNoBuilderProvided()
        {
            //Arrange
            AccountWithAddressDirector _uut = new AccountWithAddressDirector();
            int accountId = 1;
            string expectedExceptionMessage = "Builder not provided";

            //Act
            Action act = () => _uut.BuildAccount(accountId);

            //Assert
            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);
        }

        [Fact]
        public void AccountWithAddressDirector_ShouldBuildCorrectAccount_WithBuyerAccountBuilder()
        {
            //Arrange
            AccountWithAddressDirector _uut = new AccountWithAddressDirector();
            int accountId = 1;
            var expectedCity = "Balin";
            var expectedStreet = "Some Street";
            var expectedState = "Some Buyer State";
            var expectedCountry = "Buyer Country";
            var expectedPostalCode = "Buyer Postal Code";
            var expectedEmail = "My@mail.com";
            var expectedName = "Buyer Name";
            var builder = new BuyerAccountBuilder();

            //Act
            _uut.SetBuilder(builder);
            _uut.BuildAccount(accountId);
            var result = builder.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedName, result.Name);
            Assert.Equal(expectedEmail, result.Email);
            Assert.NotNull(result.Address);
            var address = result.Address;
            Assert.Equal(expectedCity, address.City);
            Assert.Equal(expectedStreet, address.Street);
            Assert.Equal(expectedState, address.State);
            Assert.Equal(expectedCountry, address.Country);
            Assert.Equal(expectedPostalCode, address.PostalCode);
            Assert.Null(result.Orders);
        }

        [Fact]
        public void AccountWithAddressDirector_ShouldBuildCorrectAccount_WithSellerAccountBuilder()
        {
            //Arrange
            AccountWithAddressDirector _uut = new AccountWithAddressDirector();
            int accountId = 1;
            var expectedCity = "City of Angels";
            var expectedStreet = "Groove Street";
            var expectedState = "Mazowsze";
            var expectedCountry = "Poland";
            var expectedPostalCode = "12345";
            var expectedEmail = "Maciek@Maciek.pl";
            var expectedName = "Maciek";
            var expectedPhoneNumber = "+48 484848489";
            var builder = new SellerAccountBuilder();

            //Act
            _uut.SetBuilder(builder);
            _uut.BuildAccount(accountId);
            var result = builder.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedName, result.Name);
            Assert.Equal(expectedEmail, result.Email);
            Assert.Equal(expectedPhoneNumber, result.Phone);
            Assert.NotNull(result.Address);
            var address = result.Address;
            Assert.Equal(expectedCity, address.City);
            Assert.Equal(expectedStreet, address.Street);
            Assert.Equal(expectedState, address.State);
            Assert.Equal(expectedCountry, address.Country);
            Assert.Equal(expectedPostalCode, address.PostalCode);
            Assert.Null(result.Orders);
        }
    }
}
