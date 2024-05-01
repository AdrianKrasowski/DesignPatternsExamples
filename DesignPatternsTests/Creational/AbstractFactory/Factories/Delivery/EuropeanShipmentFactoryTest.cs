
using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery;
using Xunit;
using DesignPatternsExamples.Creational.AbstractFactory.Models.EuropeanShipment;

namespace DesignPatternsTests.Creational.AbstractFactory.Factories.Delivery
{
    public class EuropeanShipmentFactoryTest
    {
        //Arrange
        private readonly IDeliveryFactory _uut = new EuropeanShipmentFactory();

        [Fact]
        public void EuropeanShipmentFactoryShouldReturnEuropeanDeliveryRates()
        {
            //Act
            var result = _uut.GetDeliveryRates();

            //Assert
            Assert.IsType<EuropeanDeliveryRates>(result);
        }

        [Fact]
        public void EuropeanShipmentFactoryShouldReturnEuropeanDeliverySpecification()
        {
            //Act
            var result = _uut.GetDeliverySpecification();

            //Assert
            Assert.IsType<EuropeanDeliverySpecification>(result);
        }

        [Fact]
        public void EuropeanShipmentFactoryShouldReturnEuropeanShipmentSpecification()
        {
            //Act
            var result = _uut.GetShipmentSpecification();

            //Assert
            Assert.IsType<EuropeanShipmentSpecification>(result);
        }
    }
}
