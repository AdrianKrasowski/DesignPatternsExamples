using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth
{
    public class Hat : Equipment, IHelmet
    {
        public decimal Defense { get; protected set; }
        public string Description { get; protected set; }

        public Hat()
        {
            IsEquiped = false;
        }

        public Hat(decimal defense, string name, string description)
        {
            IsEquiped = false;
            Defense = defense;
            Name = name;
            Description = description;
        }
    }
}