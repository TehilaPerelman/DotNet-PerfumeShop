using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface IOrder
    {
        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount);
        public void CalcTotalPriceForProduct(BO.ProductInOrder product);
        public void CalcTotalPrice(BO.Order order);
        public void DoOrder(BO.Order order);
        public void SearchSaleForProduct(ProductInOrder productId, bool isPreferredCustomer);
    }
}






