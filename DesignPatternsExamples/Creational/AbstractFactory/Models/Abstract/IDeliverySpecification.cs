namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract
{
    public interface IDeliverySpecification
    {
        string GetDeliveryDocument(string address);
    }
}
