using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Plate
{
    public class PlateHelmet : Equipment, IHelmet
    {
        public decimal Defense { get; protected set; }

        public string Description { get; protected set; }

        public PlateHelmet(decimal defense, string name, string description)
        {
            IsEquiped = false;
            Defense = defense;
            Name = name;
            Description = description;
        }
    }
}