using DesignPatternsExamples.Structural.Adapter.Payments.Abstract;

namespace DesignPatternsExamples.Structural.Adapter.Payments
{
    internal class StandardPayment : IPayment
    {
        public bool GetPaymentConfirmation(int paymentId)
        {
            return true;
        }

        public int SendPayment(int payAccount, int receiverAccount, decimal amount)
        {
            int paymentId = 123;
            return paymentId;
        }
    }
}
