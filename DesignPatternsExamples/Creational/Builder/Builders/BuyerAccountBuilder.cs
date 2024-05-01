using DesignPatternsExamples.Creational.Builder.Builders.Abstract;
using DesignPatternsExamples.Creational.Builder.Model;
using DesignPatternsExamples.Creational.Builder.Model.Accounts;
using System.Collections.Generic;

namespace DesignPatternsExamples.Creational.Builder.Builders
{
    public class BuyerAccountBuilder : IAccountBuilder
    {
        private BuyerAccount _buyerAccount;
        public void Reset()
        {
            _buyerAccount = new BuyerAccount();
        }

        public void SetAccountAddress()
        {
            //Add code to request User address based on account id
            _buyerAccount.Address = new Address
            {
                City = "Balin",
                Street = "Some Street",
                State = "Some Buyer State",
                Country = "Buyer Country",
                PostalCode = "Buyer Postal Code"
            };
        }

        public void SetAccountBaseInfo()
        {
            //Add code to request User info based on account id
            _buyerAccount.Email = "My@mail.com";
            _buyerAccount.Name = "Buyer Name";
        }

        public void SetAccountId(int id)
        {
            _buyerAccount.Id = id;
        }

        public void SetAccountOrders()
        {
            //Add code to request User orders based on account id
            _buyerAccount.Orders = new List<Order>()
            {
                new Order
                {
                    BuyerID = _buyerAccount.Id,
                    SellerID = 2,
                    Products = new List<Product>{
                        new Product
                        {
                            Id = 1,
                            Name = "Laptop",
                            Description = ""
                        },
                        new Product
                        {

                        }
                    }
                   
                }
            };
        }
    }
}
