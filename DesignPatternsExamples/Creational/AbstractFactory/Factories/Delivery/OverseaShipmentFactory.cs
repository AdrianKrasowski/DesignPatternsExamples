using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.OverseaShipment;

namespace DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery
{
    public class OverseaShipmentFactory : IDeliveryFactory
    {
        public IDeliverySpecification GetDeliverySpecification()
        {
            return new OverseaDeliverySpecification();
        }

        public IDeliveryRates GetDeliveryRates()
        {
            return new OverseaDeliveryRates();
        }

        public IShipmentSpecification GetShipmentSpecification()
        {
            return new OverseaShipmentSpecification();
        }
    }
}
