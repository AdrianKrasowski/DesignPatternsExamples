using DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.DomesticShipment;

namespace DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery
{
    public class DomesticShipmentFactory : IDeliveryFactory
    {
        public IDeliverySpecification GetDeliverySpecification()
        {
            return new DomesticDeliverySpecification();
        }

        public IDeliveryRates GetDeliveryRates()
        {
            return new DomesticDeliveryRates();
        }

        public IShipmentSpecification GetShipmentSpecification()
        {
            return new DomesticShipmentSpecification();
        }
    }
}
