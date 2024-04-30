using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Factories.Delivery.Abstract
{
    public interface IDeliveryFactory
    {
        IDeliverySpecification GetDeliverySpecification();
        IDeliveryRates GetDeliveryRates();
        IShipmentSpecification GetShipmentSpecification();
    }
}
