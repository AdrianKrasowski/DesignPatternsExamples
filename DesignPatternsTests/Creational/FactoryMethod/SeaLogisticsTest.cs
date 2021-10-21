using DesignPatternsExamples.FactoryMethod;
using DesignPatternsExamples.FactoryMethod.Models;
using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using Xunit;

namespace DesignPatternsTests.FactoryMethod
{
    public class SeaLogisticsTest
    {
        [Fact]
        public void ShouldUseBoatAsSeaTransport()
        {
            //Arrange
            var _uut = new SeaLogistics();
            var expectedTransportName = "Boat";

            //Act
            _uut.Deliver();

            //Assert
            Assert.Equal(expectedTransportName, _uut.Transport.Name);
        }

        [Fact]
        public void TransportShouldBeOfTypeBoat()
        {
            //Arrange
            var _uut = new SeaLogistics();

            //Act
            _uut.Deliver();

            //Assert
            Assert.IsType<Boat>(_uut.Transport);
        }

        [Fact]
        public void TransportShouldDerriveOfTypeITransport()
        {
            //Arrange
            var _uut = new SeaLogistics();

            //Act
            _uut.Deliver();

            //Assert
            Assert.IsAssignableFrom<ITransport>(_uut.Transport);
        }

        [Fact]
        public void DeliverShouldReturnExpectedMessage()
        {
            //Arrange
            var _uut = new SeaLogistics();
            var expectedMessage = "Order was delivered with Boat";

            //Act
            var actualResult = _uut.Deliver();

            //Assert
            Assert.Equal(expectedMessage, actualResult);
        }
    }
}