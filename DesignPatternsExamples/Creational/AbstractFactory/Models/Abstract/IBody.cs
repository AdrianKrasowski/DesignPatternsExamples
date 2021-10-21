namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract
{
    public interface IBody
    {
        decimal Defense { get; }
        string Name { get; }
        bool IsEquiped { get; }
        string Description { get; }
        IGauntlets Gauntlets { get; }

        string Equip();

        string Uneqip();

        string AttachGloves(IGauntlets gauntlets);

        string DetachGloves();
    }
}