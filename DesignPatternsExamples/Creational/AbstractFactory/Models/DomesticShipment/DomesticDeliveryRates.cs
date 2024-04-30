using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.DomesticShipment
{
    public class DomesticDeliveryRates : IDeliveryRates
    {
        public double GetPrice(double price)
        {
            throw new System.NotImplementedException();
        }
    }
}
