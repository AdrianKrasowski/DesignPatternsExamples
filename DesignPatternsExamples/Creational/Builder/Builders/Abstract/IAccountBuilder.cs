namespace DesignPatternsExamples.Creational.Builder.Builders.Abstract
{
    public interface IAccountBuilder
    {
        void Reset();
        void SetAccountId(int id);
        void SetAccountBaseInfo();
        void SetAccountAddress();
        void SetAccountOrders();
    }
}
