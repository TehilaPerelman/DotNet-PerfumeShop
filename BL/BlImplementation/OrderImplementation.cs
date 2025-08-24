using BLApi;

using BO;
using DalFacade.DO;
using DO;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class OrderImplementation : IOrder
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;


        public void SearchSaleForProduct(ProductInOrder productInOrder, bool isFavorate)
        {
            try
            {
                var salesInProduct = from sale in _dal.Sale.ReadAll(s => s.id == productInOrder.ProductId)
                                     where sale.start <= DateTime.Now && sale.end > DateTime.Now &&
                                             (sale.club != false || isFavorate != false) &&
                                             sale.count_sale <= productInOrder.Amount
                                     orderby sale.price_sale / sale.count_sale
                                     select new SaleInProduct(sale.UniqueId, sale.count_sale, sale.price_sale, sale.club);


                productInOrder.SaleInProduct = salesInProduct.ToList();
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Such Sales Not Found In Sales", ex);
            }

        }

        public List<BO.SaleInProduct> AddProductToOrder(BO.Order order, int productId, int amount)
        {
            try
            {
                DO.Product prod = _dal.Product.Read(productId);
                BO.ProductInOrder? prod2;

                if (order.ProductsInOrderList.Any())
                {
                    prod2 = order.ProductsInOrderList.FirstOrDefault(p => p.ProductId == prod.id);
                    if (prod2 != null)
                    {
                        if (prod.count >= amount + prod2.Amount)
                            prod2.Amount += amount;

                        else
                            throw new BlNotEnoughInStockException("Not Enough Products In Stock");
                    }

                    else
                    {
                        if (prod.count >= amount)
                        {
                            prod2 = new ProductInOrder(prod.id, prod.ProductName, prod.price_product, amount, 0.0);
                            order.ProductsInOrderList.Add(prod2);

                        }
                        else
                            throw new BlNotEnoughInStockException("Not Enough Products In Stock");

                    }
                }

                else
                {
                    if (prod.count >= amount)
                    {
                        prod2 = new ProductInOrder(prod.id, prod.ProductName, prod.count, amount, 0.0);
                        order.ProductsInOrderList.Add(prod2);

                    }
                    else
                        throw new BlNotEnoughInStockException("Not Enough Products In Stock");

                }
                SearchSaleForProduct(prod2, order.IsPreferredCustomer);
                CalcTotalPriceForProduct(prod2);
                CalcTotalPrice(order);
                return prod2.SaleInProduct;
            }
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Product Id Not Found In Products", ex);
            }
        }

        public void CalcTotalPriceForProduct(BO.ProductInOrder prod)
        {

            int count = prod.Amount;
            prod.FinalPrice = 0;
            List<SaleInProduct> usedSales = new List<SaleInProduct>();

            foreach (BO.SaleInProduct sale in prod.SaleInProduct)
            {

                if (count < sale.SaleAmount)
                    continue;
                prod.FinalPrice += ((count / sale.SaleAmount) * sale.SalePrice);
                count = (count % sale.SaleAmount);
                usedSales.Add(sale);
                if (count == 0)
                    break;

            }
            prod.FinalPrice += (prod.BasePrice * count);
            prod.SaleInProduct = usedSales;


        }

        public void CalcTotalPrice(BO.Order order)
        {

            order.TotalPrice = order.ProductsInOrderList.Sum(p => p.FinalPrice);

        }


        public void DoOrder(BO.Order order)
        {

            try
            {


                foreach (ProductInOrder p in order.ProductsInOrderList)
                {
                    DO.Product prod = _dal.Product.Read(p1 => p1.id == p.ProductId);
                    DO.Product p1 = prod with { count = prod.count - p.Amount };

                    _dal.Product.Update(p1);
                }


            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Product Not Found In Products", ex);
            }
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Product Id Not In Products", ex);
            }

        }
    }
}
