using Xunit;
using DesignPatternsExamples.Creational.Builder.Builders;
using System;
using DesignPatternsExamples.Creational.Builder.Model;

namespace DesignPatternsTests.Creational.Builder.Builders
{
    public class BuyerAccountBuilderTests
    {

        [Fact]
        public void BuyerAccountBuilder_ShouldCorrectlySetAccountId_ForCorrectIdValues()
        {
            //Arrange
            int accountId = 10;
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();

            //Act
            _uut.SetAccountId(accountId);
            var result = _uut.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(result.Id, accountId);
        }

        [Fact]
        public void BuyerAccountBuilder_ShouldThrowException_IfInvalidIdPassed()
        {
            //Arrange
            int accountId = -1;
            string expectedExceptionMessage = "Account Id cannot be lesser than 1";
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();

            //Act   
            Action act = () => _uut.SetAccountId(accountId);

            //Assert
            ArgumentException exception = Assert.Throws<ArgumentException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);
        }

        [Fact]
        public void BuyerAccountBuilder_ShouldThrowException_OnGetResult_IfIdIsNotSet()
        {
            //Arrange
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();
            string expectedExceptionMessage = "Build object is not initialized";

            //Act
            Action act = () => _uut.GetResult();

            //Assert
            InvalidOperationException exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);

        }

        [Fact]
        public void BuyerAccountBuilder_ShouldCorrectlySetAddress()
        {
            //Arange
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();
            int accountId = 1;
            var expectedCity = "Balin";
            var expectedStreet = "Some Street";
            var expectedState = "Some Buyer State";
            var expectedCountry = "Buyer Country";
            var expectedPostalCode = "Buyer Postal Code";

            //Act
            _uut.SetAccountId(1);
            _uut.SetAccountAddress();
            var result = _uut.GetResult();
            var address = result.Address;

            //Assert
            Assert.NotNull(result);
            Assert.NotNull(result.Address);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedCity, address.City);
            Assert.Equal(expectedStreet, address.Street);
            Assert.Equal(expectedState, address.State);
            Assert.Equal(expectedCountry, address.Country);
            Assert.Equal(expectedPostalCode, address.PostalCode);
        }

        [Fact]
        public void BuyerAcoountBuilder_ShouldCorrectlySetBasicUserInfo()
        {
            //Arrange
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();
            int accountId = 1;
            var expectedEmail = "My@mail.com";
            var expectedName = "Buyer Name";

            //Act
            _uut.SetAccountId(accountId);
            _uut.SetAccountBaseInfo();
            var result = _uut.GetResult();

            //Assert
            Assert.NotNull(result);
            Assert.Equal(accountId, result.Id);
            Assert.Equal(expectedName, result.Name);
            Assert.Equal(expectedEmail, result.Email);
        }

        [Fact]
        public void BuyerAccountBuilder_ShouldCorrectlySetOrdersList() 
        {
            //Arrange
            BuyerAccountBuilder _uut = new BuyerAccountBuilder();
            int accountId = 1;
            var expectedOrder =new Order
            {
                Id = 1,
                BuyerID = accountId,
                SellerID = 2,
            };
            var firstExpectedProduct = new Product
            {
                Id = 1,
                Name = "Laptop",
                Description = ""
            };
            var secondExpectedProduct = new Product
            {
                Id = 2,
                Name = "PC",
                Description = "Personal Computer"
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
                    Assert.Equal(expectedOrder.BuyerID, order.BuyerID);
                    Assert.Equal(expectedOrder.SellerID, order.SellerID);
                    Assert.Collection(order.Products,
                        product =>
                        {
                            Assert.Equal(firstExpectedProduct.Id, product.Id);
                            Assert.Equal(firstExpectedProduct.Name, product.Name);
                            Assert.Equal(firstExpectedProduct.Description, product.Description);
                        },
                        product =>
                        {
                            Assert.Equal(secondExpectedProduct.Id, product.Id);
                            Assert.Equal(secondExpectedProduct.Name, product.Name);
                            Assert.Equal(secondExpectedProduct.Description, product.Description);
                        }
                    );
                }
            );
            Assert.Equal(accountId, result.Id);
        }
    }
}
