using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface IProduct
    {
        public int Create(BO.Product product);
        public BO.Product Read(int id);
        public List<BO.Product?> ReadAll(Func<BO.Product, bool>? filter = null);
        public void Update(BO.Product product);
        public void Delete(int id);
        public List<BO.SaleInProduct> GetActiveSales(int productId, bool isPreferredCustomer);
    }
}
