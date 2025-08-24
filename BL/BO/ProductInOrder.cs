using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class ProductInOrder
    {
        public int ProductId { get; set; } = 0;
        public string ProductName { get; set; } = null;
        public double BasePrice { get; set; } = 0.0;
        public int Amount { get; set; } = 0;
        public List<SaleInProduct>? SaleInProduct { get; set; } = null;
        public double FinalPrice { get; set; } = 0.0;

        public ProductInOrder()
        {

        }
        public ProductInOrder(int productId, string productName, double basePrice, int amount, double finalPrice)
        {
            ProductId = productId;
            ProductName = productName;
            BasePrice = basePrice;
            Amount = amount;
            SaleInProduct = new List<SaleInProduct>();
            FinalPrice = finalPrice;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
