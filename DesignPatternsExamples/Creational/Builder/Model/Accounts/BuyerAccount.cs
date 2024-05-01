using System.Collections.Generic;

namespace DesignPatternsExamples.Creational.Builder.Model.Accounts
{
    public class BuyerAccount
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public Address Address { get; set; }
        public List<Order> Orders { get; set; }

        void CreateOrder (List<int> productsIds, int sellerId) 
        {
            //Some Code to create order
        }

    }
}
