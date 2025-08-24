using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Sale
    {
        public int id { get; set; } = 0;
        public int count_sale { get; set; } = 0;
        public int UniqueId { get; set; } = 0;
        public int price_sale { get; set; } = 0;
        public bool? club { get; set; }
        public DateTime? start { get; set; }
        public DateTime? end { get; set; }


        public Sale()
        {

        }
        public Sale(int productId, int amountForSale, int uniqueIdAuto, int priceForSale, bool isForClab, DateTime? lastTime, DateTime? endTime)
        {
            id = productId;
            count_sale = amountForSale;
            UniqueId = uniqueIdAuto;
            price_sale = priceForSale;
            club = isForClab;
            start = lastTime;
            end = endTime;
        }

        public override string ToString() => this.ToStringProperty();
    }
}
