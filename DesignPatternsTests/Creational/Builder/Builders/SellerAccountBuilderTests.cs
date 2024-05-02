using Xunit;
using DesignPatternsExamples.Creational.Builder.Builders;
using System;
using DesignPatternsExamples.Creational.Builder.Model;

namespace DesignPatternsTests.Creational.Builder.Builders
{
    public class SellerAccountBuilderTests
    {

        [Fact]
        public void SellerAccountBuilder_ShouldCorrectlySetAccountId_ForCorrectIdValues()
        {
            //Arrange
            int accountId = 10;
            SellerAccountBuilder _uut = new SellerAccountBuilder();

            //Act
            _uut.SetAccountId(accountId);
            var result = _uut.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Id, accountId);
        }

        [Fact]
        public void SellerAccountBuilder_ShouldThrowException_IfInvalidIdPassed()
        {
            //Arrange
            int accountId = -1;
            string expectedExceptionMessage = "Account Id cannot be lesser than 1";
            SellerAccountBuilder _uut = new SellerAccountBuilder();

            //Act   
            Action act = () => _uut.SetAccountId(accountId);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);
        }

        [Fact]
        public void SellerAccountBuilder_ShouldThrowException_OnGetResult_IfIdIsNotSet()
        {
            //Arrange
            SellerAccountBuilder _uut = new SellerAccountBuilder();
            string expectedExceptionMessage = "Build object is not initialized";

            //Act
            Action act = () => _uut.GetResult();

            //Assert
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);

        }

        [Fact]
        public void SellerAccountBuilder_ShouldCorrectlySetAddress()
        {
            //Arange
            SellerAccountBuilder _uut = new SellerAccountBuilder();
            int accountId = 1;
            var expectedCity = "City of Angels";
            var expectedStreet = "Groove Street";
            var expectedState = "Mazowsze";
            var expectedCountry = "Poland";
            var expectedPostalCode = "12345";

            //Act
            _uut.SetAccountId(1);
            _uut.SetAccountAddress();
            var result = _uut.GetResult();
            var address = result.Address;

            //Assert
            Assert.NotNull(result);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedCity, address.City);
            Assert.Equal(expectedStreet, address.Street);
            Assert.Equal(expectedState, address.State);
            Assert.Equal(expectedCountry, address.Country);
            Assert.Equal(expectedPostalCode, address.PostalCode);
            Assert.Null(result.Orders);
        }

        [Fact]
        public void SellerAcoountBuilder_ShouldCorrectlySetBasicUserInfo()
        {
            //Arrange
            SellerAccountBuilder _uut = new SellerAccountBuilder();
            int accountId = 1;
            var expectedEmail = "Maciek@Maciek.pl";
            var expectedName = "Maciek";
            var expectedPhoneNumber = "+48 484848489";

            //Act
            _uut.SetAccountId(accountId);
            _uut.SetAccountBaseInfo();
            var result = _uut.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedName, result.Name);
            Assert.Equal(expectedEmail, result.Email);
            Assert.Equal(expectedPhoneNumber, result.Phone);
            Assert.Null(result.Address);
            Assert.Null(result.Orders);
        }

        [Fact]
        public void SellerAccountBuilder_ShouldCorrectlySetOrdersList()
        {
            //Arrange
            SellerAccountBuilder _uut = new SellerAccountBuilder();
            int accountId = 1;
            var expectedOrder = new Order
            {
                Id = 2,
                SellerID = accountId,
                BuyerID = 2,
            };
            var firstExpectedProduct = new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = ""
            };

            //Act
            _uut.SetAccountId(accountId);
            _uut.SetAccountOrders();
            var result = _uut.GetResult();


            //Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Orders);
            var resultOrderList = result.Orders;
            Assert.Single(resultOrderList);
            Assert.Collection(result.Orders,
                order =>
                {
                    Assert.Equal(expectedOrder.Id, order.Id);
                    Assert.Equal(expectedOrder.SellerID, order.SellerID);
                    Assert.Equal(expectedOrder.BuyerID, order.BuyerID);
                    Assert.Collection(order.Products,
                        product =>
                        {
                            Assert.Equal(firstExpectedProduct.Id, product.Id);
                            Assert.Equal(firstExpectedProduct.Name, product.Name);
                            Assert.Equal(firstExpectedProduct.Description, product.Description);
                        }
                    );
                }
            );
            Assert.Equal(accountId, result.Id);
            Assert.Null(result.Address);

        }

    }
}
