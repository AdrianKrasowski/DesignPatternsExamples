using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;
using DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Plate
{
    public class PlateArmor : Equipment, IBody
    {
        public decimal Defense { get; protected set; }

        public string Description { get; protected set; }

        public IGauntlets Gauntlets { get; protected set; }

        public PlateArmor()
        {
            IsEquiped = false;
        }

        public PlateArmor(decimal defense, string name, string description)
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
            if (gauntlets.GetType() != typeof(Gauntlets))
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