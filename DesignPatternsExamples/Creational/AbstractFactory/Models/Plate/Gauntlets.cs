using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Plate
{
    public class Gauntlets : IGauntlets
    {
        public decimal Defense { get; protected set; }

        public string Name { get; protected set; }

        public bool IsAttached { get; protected set; }

        public string Description { get; protected set; }

        public Gauntlets()
        {
            IsAttached = false;
        }

        public Gauntlets(decimal defense, string name, string description)
        {
            IsAttached = false;
            Defense = defense;
            Name = name;
            Description = description;
        }

        public bool Attach()
        {
            if (IsAttached)
            {
                return false;
            }
            IsAttached = true;
            return IsAttached;
        }

        public bool Detach()
        {
            if (!IsAttached)
            {
                return false;
            }
            IsAttached = false;
            return true;
        }
    }
}