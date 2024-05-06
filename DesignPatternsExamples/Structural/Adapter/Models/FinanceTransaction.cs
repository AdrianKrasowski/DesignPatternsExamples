using System.Collections.Generic;

namespace DesignPatternsExamples.Structural.Adapter.Models
{
    public class FinanceTransaction
    {
        public int PayerID { get; set; }
        public int ReceiverID { get; set; }
        public List<decimal> PaymentAmount { get; set; } = new List<decimal>();
    }
}
