using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.OverseaShipment
{
    public class OverseaDeliveryRates : IDeliveryRates
    {
        public double GetPrice(double price)
        {
            throw new System.NotImplementedException();
        }
    }
}
