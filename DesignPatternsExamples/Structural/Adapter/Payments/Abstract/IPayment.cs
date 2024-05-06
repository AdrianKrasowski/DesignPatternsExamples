namespace DesignPatternsExamples.Structural.Adapter.Payments.Abstract
{
    public interface IPayment
    {
        int SendPayment(int payAccount, int receiverAccount, decimal amount);
        bool GetPaymentConfirmation(int paymentId);
    }
}
