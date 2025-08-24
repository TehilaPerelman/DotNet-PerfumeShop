using DO;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Product
    {
        public int id { get; set; } = 0;
        public string? name_product { get; set; } = null;
        public perfume? category { get; set; } = null;
        public int price_product { get; set; } = 0;
        public int count { get; set; } = 0;

        public List<SaleInProduct>? SaleInProduct { get; set; } = null;
        public Product(int productId, string? productName, perfume? c, int price, int amount)
        {
            id = productId;
            name_product = productName;
            price_product = price;
            count = amount;
            category = perfume.Woody;
            SaleInProduct = new List<SaleInProduct>();
        }
        public Product()
        {

        }
        public override string ToString() => this.ToStringProperty();
    }
}
