using DesignPatternsExamples.Creational.Builder.Builders.Abstract;

namespace DesignPatternsExamples.Creational.Builder.Directors.Abstract
{
    public interface IAccountDirector
    {
        IAccountBuilder Builder { get; }
        void SetBuilder(IAccountBuilder builder);
        void BuildAccount(int accountId);
    }
}
