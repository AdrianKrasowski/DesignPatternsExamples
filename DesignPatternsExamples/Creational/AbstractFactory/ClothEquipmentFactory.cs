using DesignPatternsExamples.Creational.AbstractFactory.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory
{
    public class ClothEquipmentFactory : IEquipmentFactory
    {
        public IBody CreateBody(decimal defense, string name, string description)
        {
            return new Robe(defense, name, description);
        }

        public IGauntlets CreateGauntlets(decimal defense, string name, string description)
        {
            return new Gloves(defense, name, description);
        }

        public IHelmet CreateHelmet(decimal defense, string name, string description)
        {
            return new Hat(defense, name, description);
        }
    }
}