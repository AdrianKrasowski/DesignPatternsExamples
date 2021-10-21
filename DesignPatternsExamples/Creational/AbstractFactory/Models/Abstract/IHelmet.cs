namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract
{
    public interface IHelmet
    {
        decimal Defense { get; }
        string Name { get; }
        bool IsEquiped { get; }
        string Description { get; }

        string Equip();

        string Uneqip();
    }
}