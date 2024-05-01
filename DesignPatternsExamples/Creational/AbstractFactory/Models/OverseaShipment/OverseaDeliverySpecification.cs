using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.OverseaShipment
{
    public class OverseaDeliverySpecification : IDeliverySpecification
    {
        public string GetDeliveryDocument(string address)
        {
            throw new System.NotImplementedException();
        }
    }
}
