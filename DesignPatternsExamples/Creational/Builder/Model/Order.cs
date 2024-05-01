using System.Collections.Generic;

namespace DesignPatternsExamples.Creational.Builder.Model
{
    public class Order
    {
        public int Id { get; set; }
        public int SellerID { get; set; }
        public int BuyerID { get; set; }
        public List<Product> Products { get; set; }
    }
}
