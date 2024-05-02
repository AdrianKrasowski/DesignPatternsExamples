using DesignPatternsExamples.Creational.Builder.Builders.Abstract;
using DesignPatternsExamples.Creational.Builder.Directors.Abstract;
using System;

namespace DesignPatternsExamples.Creational.Builder.Directors
{
    public class BasicAccountDirector : IAccountDirector
    {
        public IAccountBuilder Builder { get; private set; }

        public void BuildAccount(int accountId)
        {
            if (Builder == null)
                throw new InvalidOperationException("Builder not provided");
            Builder.SetAccountId(accountId);
            Builder.SetAccountBaseInfo();
        }

        public void SetBuilder(IAccountBuilder builder)
        {
            Builder = builder;
        }
    }
}
