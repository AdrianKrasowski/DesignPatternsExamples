using System.Collections.Generic;

namespace DesignPatternsExamples.Creational.Builder.Model.Accounts
{
    public class SellerAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }

        public void ConfirmOrder(int orderId)
        {
            //Some code to confirm order
        }

    }
}
