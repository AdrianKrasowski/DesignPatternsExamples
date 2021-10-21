using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;
using System;
using System.Collections.Generic;
using System.Text;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Cloth
{
    public class Robe : Equipment, IBody
    {
        public decimal Defense { get; private set; }

        public string Description { get; private set; }

        public IGauntlets Gauntlets { get; protected set; }

        public Robe()
        {
            IsEquiped = false;
        }

        public Robe(decimal defense, string name, string description)
        {
            IsEquiped = false;
            Defense = defense;
            Name = name;
            Description = description;
        }

        public string AttachGloves(IGauntlets gauntlets)
        {
            if (gauntlets.IsAttached)
            {
                throw new AlreadyAttachedException($"{gauntlets.Name} cannot be attached");
            }
            if (gauntlets.GetType() != typeof(Gloves))
            {
                throw new WrongArmorClassException($"{gauntlets.Name} cannot be attached");
            }
            gauntlets.Attach();
            Gauntlets = gauntlets;
            return $"{gauntlets.Name} has been attached to {Name}";
        }

        public string DetachGloves()
        {
            if (Gauntlets == null)
            {
                throw new NothingToBeUnatachedException($"Armor has no gauntlets attached");
            }

            Gauntlets.Detach();
            var name = Gauntlets.Name;
            Gauntlets = null;
            return $"{name} successfully detached";
        }
    }
}