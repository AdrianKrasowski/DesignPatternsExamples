using DesignPatternsExamples.Creational.Builder.Builders;
using DesignPatternsExamples.Creational.Builder.Directors;
using DesignPatternsExamples.Creational.Builder.Model;
using System;
using Xunit;

namespace DesignPatternsTests.Creational.Builder.Directors
{
    public class CompleteAccountDirectorTests
    {
        [Fact]
        public void CompleteAccountDirector_ShouldThrowInvalidOperationException_IfNoBuilderProvided()
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
        public void CompleteAccountDirector_ShouldBuildCorrectAccount_WithBuyerAccountBuilder()
        {
            //Arrange
            CompleteAccountDirector _uut = new CompleteAccountDirector();
            int accountId = 1;
            var expectedCity = "Balin";
            var expectedStreet = "Some Street";
            var expectedState = "Some Buyer State";
            var expectedCountry = "Buyer Country";
            var expectedPostalCode = "Buyer Postal Code";
            var expectedEmail = "My@mail.com";
            var expectedName = "Buyer Name";
            var expectedOrder = new Order
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
        }

        [Fact]
        public void CompleteAccountDirector_ShouldBuildCorrectAccount_WithSellerAccountBuilder()
        {
            //Arrange
            CompleteAccountDirector _uut = new CompleteAccountDirector();
            int accountId = 1;
            var expectedCity = "City of Angels";
            var expectedStreet = "Groove Street";
            var expectedState = "Mazowsze";
            var expectedCountry = "Poland";
            var expectedPostalCode = "12345";
            var expectedEmail = "Maciek@Maciek.pl";
            var expectedName = "Maciek";
            var expectedPhoneNumber = "+48 484848489";
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
        }
    }
}
