using DesignPatternsExamples.Creational.AbstractFactory.Exceptions;

namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract
{
    public abstract class Equipment
    {
        public bool IsEquiped { get; protected set; }
        public string Name { get; protected set; }

        public virtual string Equip()
        {
            if (IsEquiped)
            {
                throw new AlreadyEquipedException($"{Name} is already equipped");
            }
            IsEquiped = true;
            return $"{Name} has been equiped";
        }

        public virtual string Uneqip()
        {
            if (!IsEquiped)
            {
                throw new NotEquippedException($"{Name} is not equipped");
            }
            IsEquiped = false;
            return $"{Name} has been unequipped";
        }
    }
}