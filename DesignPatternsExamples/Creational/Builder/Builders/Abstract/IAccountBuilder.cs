namespace DesignPatternsExamples.Creational.Builder.Builders.Abstract
{
    public interface IAccountBuilder
    {
        void Reset();
        void SetAccountId(int id);
        void SetAccountAddress();
        void SetAccountOrders();
    }
}
