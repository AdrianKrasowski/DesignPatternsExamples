using DesignPatternsExamples.Creational.Builder.Builders.Abstract;
using DesignPatternsExamples.Creational.Builder.Model;
using DesignPatternsExamples.Creational.Builder.Model.Accounts;
using System;
using System.Collections.Generic;

namespace DesignPatternsExamples.Creational.Builder.Builders
{
    public class SellerAccountBuilder : IAccountBuilder
    {
        private SellerAccount _sellerAccount = new SellerAccount();
        public void Reset()
        {
            _sellerAccount = new SellerAccount();
        }

        public void SetAccountAddress()
        {
            //Add code to request User address based on account id
            _sellerAccount.Address = new Address
            {
                City = "City of Angels",
                Country = "Poland",
                PostalCode = "12345",
                State = "Mazowsze",
                Street = "Groove Street"
            };
        }

        public void SetAccountBaseInfo()
        {
            //Add code to request User info based on account id
            _sellerAccount.Name = "Maciek";
            _sellerAccount.Email = "Maciek@Maciek.pl";
            _sellerAccount.Phone = "+48 484848489";
        }

        public void SetAccountId(int id)
        {
            _sellerAccount.Id = id;
        }

        public void SetAccountOrders()
        {
            _sellerAccount.Orders = new List<Order>()
            {
                new Order
                {
                    BuyerID = 2,
                    SellerID = _sellerAccount.Id,
                    Products = new List<Product>{
                        new Product
                        {
                            Id = 1,
                            Name = "Laptop",
                            Description = ""
                        }
                    }
                }
            };
        }
        public SellerAccount GetResult()
        {
            if (_sellerAccount?.Id != 0)
            {
                return _sellerAccount;
            }
            throw new InvalidOperationException();
        }
    }
}
