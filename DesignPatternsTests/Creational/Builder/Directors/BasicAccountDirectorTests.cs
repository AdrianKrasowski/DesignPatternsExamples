using DesignPatternsExamples.Creational.Builder.Builders;
using DesignPatternsExamples.Creational.Builder.Directors;
using System;
using Xunit;

namespace DesignPatternsTests.Creational.Builder.Directors
{
    public class BasicAccountDirectorTests
    {

        [Fact]
        public void BasicAccountDirector_ShouldThrowInvalidOperationException_IfNoBuilderProvided()
        {
            //Arrange
            BasicAccountDirector _uut = new BasicAccountDirector();
            int accountId = 1;
            string expectedExceptionMessage = "Builder not provided";

            //Act
            Action act = () => _uut.BuildAccount(accountId);

            //Assert
            var exception = Assert.Throws<InvalidOperationException>(act);
            Assert.Equal(expectedExceptionMessage, exception.Message);
        }

        [Fact]
        public void BasicAccountDirector_ShouldBuildCorrectAccount_WithBuyerAccountBuilder()
        {
            //Arrange
            BasicAccountDirector _uut = new BasicAccountDirector();
            int accountId = 1;
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
            Assert.Null(result.Address);
            Assert.Null(result.Orders);
        }

        [Fact]
        public void BasicAccountDirector_ShouldBuildCorrectAccount_WithSellerAccountBuilder()
        {
            //Arrange
            BasicAccountDirector _uut = new BasicAccountDirector();
            int accountId = 1;
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
            Assert.Null(result.Address);
            Assert.Null(result.Orders);
        }
    }
}
