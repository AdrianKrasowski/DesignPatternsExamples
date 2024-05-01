using DesignPatternsExamples.Creational.Builder.Builders.Abstract;
using DesignPatternsExamples.Creational.Builder.Directors.Abstract;

namespace DesignPatternsExamples.Creational.Builder.Directors
{
    public class CompleteAccountDirector : IAccountDirector
    {
        public IAccountBuilder Builder { get => throw new System.NotImplementedException(); set => throw new System.NotImplementedException(); }

        public void BuildAccount(int accountId)
        {
            throw new System.NotImplementedException();
        }

        public void SetBuilder(IAccountBuilder builder)
        {
            throw new System.NotImplementedException();
        }
    }
}
