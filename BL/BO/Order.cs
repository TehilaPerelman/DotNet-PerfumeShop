using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Order
    {
        public bool IsPreferredCustomer { get; set; } = false;
        public List<BO.ProductInOrder> ProductsInOrderList { get; set; }
        public double TotalPrice { get; set; } = 0.0;


        public Order()
        {

        }
        public Order(bool isPreferredCus)
        {
            IsPreferredCustomer = isPreferredCus;
            ProductsInOrderList = new List<BO.ProductInOrder>();

        }

        public override string ToString() => this.ToStringProperty();

    }
}
