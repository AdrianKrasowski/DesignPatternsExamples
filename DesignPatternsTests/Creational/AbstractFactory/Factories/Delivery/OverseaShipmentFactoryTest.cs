using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery;
using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.EuropeanShipment;
using DesignPatternsExamples.Creational.AbstractFactory.Models.OverseaShipment;
using Xunit;

namespace DesignPatternsTests.Creational.AbstractFactory.Factories.Delivery
{
    public class OverseaShipmentFactoryTest
    {
        IDeliveryFactory _uut = new OverseaShipmentFactory();

        [Fact]
        public void OverseaShipmentFactoryShouldReturnOverseaDeliveryRates()
        {
            //Act
            var result = _uut.GetDeliveryRates();

            //Assert
            Assert.IsType<OverseaDeliveryRates>(result);
        }

        [Fact]
        public void OverseaShipmentFactoryShouldReturnOverseaDeliverySpecification()
        {
            //Act
            var result = _uut.GetDeliverySpecification();

            //Assert
            Assert.IsType<OverseaDeliverySpecification>(result);
        }

        [Fact]
        public void OverseaShipmentFactoryShouldReturnOverseaShipmentSpecification()
        {
            //Act
            var result = _uut.GetShipmentSpecification();

            //Assert
            Assert.IsType<OverseaShipmentSpecification>(result);
        }
    }
}
