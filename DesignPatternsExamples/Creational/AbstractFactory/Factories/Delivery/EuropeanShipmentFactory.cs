using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.EuropeanShipment;

namespace DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery
{
    public class EuropeanShipmentFactory : IDeliveryFactory
    {
        public IDeliverySpecification GetDeliverySpecification()
        {
            return new EuropeanDeliverySpecification();
        }

        public IDeliveryRates GetDeliveryRates()
        {
            return new EuropeanDeliveryRates();
        }

        public IShipmentSpecification GetShipmentSpecification()
        {
            return new EuropeanShipmentSpecification();
        }
    }
}
