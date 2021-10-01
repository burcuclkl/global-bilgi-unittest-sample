using GlobalBilgi.Core.Entities.Base;
using System;
using System.Collections.Generic;
using System.Text;

namespace GlobalBilgi.Core.Entities.Models
{
    public class Product : Entity
    {
        public string ProductName { get; set; }

        public decimal UnitPrice { get; set; }

        public int UnitsInStock { get; set; }

        public Product()
        {

        }


        public Product(string productName, decimal unitPrice,int unitsInStock)
        {
            this.ProductName = productName;
            this.UnitPrice = unitPrice;
            this.UnitsInStock = unitsInStock;
        }



        public static Product Create(string productName, decimal unitPrice, int unitsInStock)
        {
            var product = new Product
            {
                ProductName = productName,
                UnitPrice = unitPrice,
                UnitsInStock = unitsInStock
            };

            return product;
        }
    }
}
