using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static BO.Tools;
using BLApi;
using DalFacade.DO;
using BO;

namespace BlImplementation
{
    public class SaleImplementation : ISale
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;

        public int Create(BO.Sale Sale)
        {
            try
            {
                DO.Sale SaleDO = Sale.ConvertToDoSale();
                return _dal.Sale.Create(SaleDO);

            }

            catch (DalIdAlreadyExistsException ex)
            {
                throw new BlIdAlreadyExistsException("Sale Already Exists In Sales", ex);
            }
        }

        public BO.Sale Read(int id)
        {
            try
            {
                DO.Sale SaleDO = _dal.Sale.Read(id);
                if (SaleDO == null)
                    return null;
                return SaleDO.ConvertToBoSale();
            }
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Id Not Found in Sales", ex);
            }
        }

        public List<BO.Sale?> ReadAll(Func<BO.Sale, bool>? filter = null)
        {
            try
            {

                List<DO.Sale> SalesDO;
                if (filter != null)
                    SalesDO = _dal.Sale.ReadAll(doCust => filter(doCust.ConvertToBoSale()));
                else
                    SalesDO = _dal.Sale.ReadAll();

                List<BO.Sale> SalesBO = SalesDO
                    .Select(c => c.ConvertToBoSale())
                    .ToList();

                return SalesBO;
            }

            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Sales Not Found In Sales", ex);
            }
        }

        public void Update(BO.Sale Sale)
        {
            try
            {
                DO.Sale SaleDO = Sale.ConvertToDoSale();
                _dal.Sale.Update(SaleDO);
            }

            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Sale Id Not Found In Sales", ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Sale.Delete(id);
            }

            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Id Not Found in Sales", ex);
            }
        }
        public BO.Sale? Read(Func<BO.Sale, bool> filter)
        {
            try
            {
                return _dal.Sale.Read(p => filter(p.ConvertToBoSale())).ConvertToBoSale();
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Sale Not Found In Sales", ex);
            }
        }


    }
}
