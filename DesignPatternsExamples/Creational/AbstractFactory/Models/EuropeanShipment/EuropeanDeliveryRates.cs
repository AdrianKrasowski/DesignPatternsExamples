using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.EuropeanShipment
{
    public class EuropeanDeliveryRates : IDeliveryRates
    {
        public double GetPrice(double price)
        {
            throw new System.NotImplementedException();
        }
    }
}
