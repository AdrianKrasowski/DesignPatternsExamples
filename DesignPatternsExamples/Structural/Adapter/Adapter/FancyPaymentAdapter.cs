using DesignPatternsExamples.Structural.Adapter.Models;
using DesignPatternsExamples.Structural.Adapter.Payments;
using DesignPatternsExamples.Structural.Adapter.Payments.Abstract;

namespace DesignPatternsExamples.Structural.Adapter.Adapter
{
    public class FancyPaymentAdapter : IPayment
    {
        private readonly FancyPayment fancyPayment;

        public FancyPaymentAdapter(FancyPayment fancyPayment)
        {
            this.fancyPayment = fancyPayment;
        }

        public bool GetPaymentConfirmation(int paymentId)
        {
            return fancyPayment.CheckIfTransactionBooked(paymentId);
        }

        public int SendPayment(int payAccount, int receiverAccount, decimal amount)
        {
            FinanceTransaction transaction = new FinanceTransaction();
            fancyPayment.SetTransactionPayer(transaction, payAccount);
            fancyPayment.SetTransactionReceiver(transaction, receiverAccount);
            fancyPayment.AddPayment(transaction, amount);
            return fancyPayment.CommitTransaction(transaction); 
        }
    }
}
