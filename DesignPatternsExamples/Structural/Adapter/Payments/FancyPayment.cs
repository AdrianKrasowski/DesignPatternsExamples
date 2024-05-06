using DesignPatternsExamples.Structural.Adapter.Models;
using System.Linq;

namespace DesignPatternsExamples.Structural.Adapter.Payments
{
    public class FancyPayment
    {
        public void SetTransactionPayer(FinanceTransaction transaction, int payerId)
        {
            transaction.PayerID = payerId;
        }

        public void SetTransactionReceiver(FinanceTransaction transaction, int receiverId)
        {
            transaction.PayerID = receiverId;
        }

        public void AddPayment(FinanceTransaction transaction, decimal amount)
        {
            transaction.PaymentAmount.Add(amount);
        }

        public int CommitTransaction(FinanceTransaction transaction)
        {
            return transaction.PayerID + transaction.ReceiverID + (int)transaction.PaymentAmount.Sum(x => x);
        }

        public bool CheckIfTransactionBooked(int transactionId)
        {
            return true;
        }
    }
}
