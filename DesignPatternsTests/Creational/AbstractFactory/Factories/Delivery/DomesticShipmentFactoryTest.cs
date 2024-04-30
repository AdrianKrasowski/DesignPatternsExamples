using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery;
using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.DomesticShipment;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Factories.Delivery
{
    public class DomesticShipmentFactoryTest
    {
        //Arrange
        private IDeliveryFactory _uut = new DomesticShipmentFactory();
        
        [Fact]
        public void DomesticShipmentyFactoryShouldReturnDomesticDeliveryRates()
        {

            //Act
            var actualDeliveryRates = _uut.GetDeliveryRates();

            //Assert
            Assert.IsType<DomesticDeliveryRates>(actualDeliveryRates);
        }

        [Fact]
        public void DomesticShipmentyFactoryShouldReturnDomesticShipmentSpecification()
        {

            //Act
            var actualDeliveryRates = _uut.GetShipmentSpecification();

            //Assert
            Assert.IsType<DomesticShipmentSpecification>(actualDeliveryRates);
        }

        [Fact]
        public void DomesticShipmentyFactoryShouldReturnDomesticDeliverySpecification()
        {

            //Act
            var actualDeliveryRates = _uut.GetDeliverySpecification();

            //Assert
            Assert.IsType<DomesticDeliverySpecification>(actualDeliveryRates);
        }
    }
}
