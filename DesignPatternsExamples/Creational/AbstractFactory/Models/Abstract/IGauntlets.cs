namespace DesignPatternsExamples.Creational.AbstractFactory.Models.Abstract
{
    public interface IGauntlets
    {
        decimal Defense { get; }
        string Name { get; }
        bool IsAttached { get; }
        string Description { get; }

        bool Attach();

        bool Detach();
    }
}