using BLApi;
using BO;
using DalFacade.DO;
using static BO.Tools;


namespace BlImplementation
{
    internal class ClientImplementation : IClient
    {
        private DalApi.IDal _dal = DalApi.Factory.Get;
        public int Create(BO.Client customer)
        {
            try
            {
                DO.Client customerDO = customer.ConvertToDoCustomer();
                return _dal.Client.Create(customerDO);

            }

            catch (DalIdAlreadyExistsException ex)
            {
                throw new BlIdAlreadyExistsException("Customer Already Exists In Customers", ex);
            }
        }
        public BO.Client? Read(Func<BO.Client, bool> filter)
        {
            try
            {
                DO.Client? customerDO = _dal.Client.Read(c => filter(c.ConvertToBoCustomer()));

                if (customerDO == null)
                    return null;
                return customerDO.ConvertToBoCustomer();
            }
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Customer Not Found In Customers", ex);
            }
        }

        public BO.Client Read(int id)
        {
            try
            {
                DO.Client customerDO = _dal.Client.Read(id);
                if (customerDO == null)
                    return null;
                return customerDO.ConvertToBoCustomer();
            }
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Id Not Found In Customers", ex);
            }
        }

        public List<BO.Client?> ReadAll(Func<BO.Client, bool>? filter = null)
        {
            try
            {

                List<DO.Client> customersDO;
                if (filter != null)
                    customersDO = _dal.Client.ReadAll(doCust => filter(doCust.ConvertToBoCustomer()));
                else
                    customersDO = _dal.Client.ReadAll();

                List<BO.Client> customersBO = customersDO
                    .Select(c => c.ConvertToBoCustomer())
                    .ToList();

                return customersBO;
            }
        
            catch (DalNotFoundException ex)
            {
                throw new BlNotFoundException("Customers Not Found In Customers", ex);
            }
        }

        public void Update(BO.Client customer)
        {
            try
            {
                DO.Client customerDO = customer.ConvertToDoCustomer();
                _dal.Client.Update(customerDO);
            }
          
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Customer Id Not Found", ex);
            }
        }
        public void Delete(int id)
        {
            try
            {
                _dal.Client.Delete(id);
            }

            catch (DalIdNotFoundException ex)
            {

                throw new BlIdNotFoundException("Id Not Found In Customers", ex);
            }
        }
        public bool IsCustomerExists(int id)
        {
            try
            {
                Read(id);
                return true;
            }
            catch (DalIdNotFoundException ex)
            {
                return false;
                throw new BlIdNotFoundException("Id Not Found In Customers", ex);
            }
        }



    }
}
