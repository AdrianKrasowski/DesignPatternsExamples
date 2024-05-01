using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.DomesticShipment
{
    public class DomesticDeliverySpecification : IDeliverySpecification
    {
        public string GetDeliveryDocument(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}
