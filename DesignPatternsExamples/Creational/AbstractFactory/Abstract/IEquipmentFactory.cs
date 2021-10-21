using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Abstract
{
    public interface IEquipmentFactory
    {
        IHelmet CreateHelmet(decimal defense, string name, string description);

        IBody CreateBody(decimal defense, string name, string description);

        IGauntlets CreateGauntlets(decimal defense, string name, string description);
    }
}