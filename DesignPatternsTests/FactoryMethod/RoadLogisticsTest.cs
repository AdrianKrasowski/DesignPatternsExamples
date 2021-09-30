using DesignPatternsExamples.FactoryMethod;
using DesignPatternsExamples.FactoryMethod.Models;
using DesignPatternsExamples.FactoryMethod.Models.Abstract;
using Xunit;

namespace DesignPatternsTests.FactoryMethod
{
    public class RoadLogisticsTest
    {
        [Fact]
        public void ShouldUseTruckAsRoadTransport()
        {
            //Arrange
            var _uut = new RoadLogistics();
            var expectedTransportName = "Truck";

            //Act
            _uut.Deliver();

            //Assert
            Assert.Equal(expectedTransportName, _uut.Transport.Name);
        }

        [Fact]
        public void TransportShouldBeOfTypeTruck()
        {
            //Arrange
            var _uut = new RoadLogistics();

            //Act
            _uut.Deliver();

            //Assert
            Assert.IsType<Truck>(_uut.Transport);
        }

        [Fact]
        public void TransportShouldDerriveOfTypeITransport()
        {
            //Arrange
            var _uut = new RoadLogistics();

            //Act
            _uut.Deliver();

            //Assert
            Assert.IsAssignableFrom<ITransport>(_uut.Transport);
        }

        [Fact]
        public void DeliverShouldReturnExpectedMessage()
        {
            //Arrange
            var _uut = new RoadLogistics();
            var expectedMessage = "Order was delivered with Truck";

            //Act
            var actualResult = _uut.Deliver();

            //Assert
            Assert.Equal(expectedMessage, actualResult);
        }
    }
}