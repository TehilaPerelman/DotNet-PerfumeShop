using static BO.Tools;
using BLApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DalFacade.DO;
using BO;
namespace BlImplementation
{
    public class ProductImplementation : IProduct
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(Product Product)
        {
            try
            {
                DO.Product ProductDO = Product.ConvertToDoProduct();
                return _dal.Product.Create(ProductDO);

            }

            catch (DalIdAlreadyExistsException ex)
            {
                throw new BlIdAlreadyExistsException("Product Already Exists In Products", ex);
            }
        }

        public BO.Product Read(int id)
        {
            try
            {
                DO.Product ProductDO = _dal.Product.Read(id);
                if (ProductDO == null)
                    return null;
                return ProductDO.ConvertToBoProduct();
            }
            catch (Exception ex)
            {
                throw new BlIdNotFoundException("Id Not Found in Products", ex);
            }
        }

        public BO.Product? Read(Func<BO.Product, bool> filter)
        {
            try
            {
                return _dal.Product.Read(p => filter(p.ConvertToBoProduct())).ConvertToBoProduct();
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Product Not Found In Products", ex);
            }
        }

        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null)
        {
            try
            {

                List<DO.Product> ProductsDO;
                if (filter != null)
                    ProductsDO = _dal.Product.ReadAll(doCust => filter(doCust.ConvertToBoProduct()));
                else
                    ProductsDO = _dal.Product.ReadAll();

                List<BO.Product> ProductsBO = ProductsDO
                    .Select(c => c.ConvertToBoProduct())
                    .ToList();

                return ProductsBO;
            }

            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Products Not Found In Products", ex);
            }
        }

        public void Update(BO.Product Product)
        {
            try
            {
                DO.Product ProductDO = Product.ConvertToDoProduct();
                _dal.Product.Update(ProductDO);
            }

            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Product Id Not Found In Products", ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Product.Delete(id);
            }

            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Id Not Found in Products", ex);
            }
        }



        public List<BO.SaleInProduct> GetActiveSales(int productId, bool isCustomer)
        {
            try
            {
                DateTime now = DateTime.Now;

                return _dal.Sale
                    .ReadAll(sale =>
                        sale.id == productId &&
                        sale.start <= now &&
                        sale.end >= now &&
                        (isCustomer || sale.club == false))
                    .Select(s => new BO.SaleInProduct(s.id, s.count_sale, s.price_sale, s.club))
                    .ToList();
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("No active sales found for this product.", ex);
            }
        }


    }
}
