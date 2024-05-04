using DesignPatternsExamples.Creational.Prototype.Models;

namespace DesignPatternsExamples.Creational.Prototype.Abstract
{
    public abstract class Customer
    {
        public string Name { get; set; }
        public string Surname { get; set; }
        public Address Address{ get; set; }

        public Customer() 
        {

        }
        public Customer(string name, string surname) 
        {
            Name = name;
            Surname = surname;
        }
        public Customer(string name, string surname, Address address)
        {
            Name = name; 
            Surname = surname;
            Address = address;
        }

        public abstract Customer DeepClone();
        public abstract Customer ShallowClone();
    }
}
