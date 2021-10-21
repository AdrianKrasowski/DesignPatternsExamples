using DesignPatternsExamples.Creational.AbstractFactory.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Plate;

namespace DesignPatternsExamples.Creational.AbstractFactory
{
    public class PlateEquipmentFactory : IEquipmentFactory
    {
        public IBody CreateBody(decimal defense, string name, string description)
        {
            return new PlateArmor(defense, name, description);
        }

        public IGauntlets CreateGauntlets(decimal defense, string name, string description)
        {
            return new Gauntlets(defense, name, description);
        }

        public IHelmet CreateHelmet(decimal defense, string name, string description)
        {
            return new PlateHelmet(defense, name, description);
        }
    }
}