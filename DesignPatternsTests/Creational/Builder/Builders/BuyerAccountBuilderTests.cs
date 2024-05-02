using Xunit;
using DesignPatternsExamples.Creational.Builder;
using DesignPatternsExamples.Creational.Builder.Builders;
using System;

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
    }
}
