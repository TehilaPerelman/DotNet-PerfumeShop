using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class SaleInProduct
    {
        public int SaleId { get; set; } = 0;
        public int SaleAmount { get; set; } = 0;
        public double SalePrice { get; set; } = 0.0;
        public bool? IsForClab { get; set; }

        public SaleInProduct()
        {

        }
        public SaleInProduct(int saleId, int saleAmount, double salePrice, bool? isForClab)
        {
            SaleId = saleId;
            SaleAmount = saleAmount;
            SalePrice = salePrice;
            IsForClab = isForClab;
        }
        public override string ToString() => this.ToStringProperty();
    }
}
