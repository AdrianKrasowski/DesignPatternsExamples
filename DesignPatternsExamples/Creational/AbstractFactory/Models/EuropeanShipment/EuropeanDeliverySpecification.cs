using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.EuropeanShipment
{
    public class EuropeanDeliverySpecification : IDeliverySpecification
    {
        public string GetDeliveryDocument(string address)
        {
            throw new System.NotImplementedException();
        }      
    }
}
