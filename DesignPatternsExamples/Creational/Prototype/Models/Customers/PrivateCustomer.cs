using DesignPatternsExamples.Creational.Prototype.Abstract;

namespace DesignPatternsExamples.Creational.Prototype.Models.Customers
{
    public class PrivateCustomer : Customer
    {
        public bool IsLegallyAdult { get; set; }

        public override Customer DeepClone()
        {
            var clone = new PrivateCustomer()
            {
                Name = Name,
                Surname = Surname,
                Address = Address == null ? null : new Address(Address.Street, Address.City, Address.Country),
                IsLegallyAdult = IsLegallyAdult
            };
            return clone;
        }

        public override Customer ShallowClone()
        {
            return (PrivateCustomer)MemberwiseClone();
        }
    }
}
