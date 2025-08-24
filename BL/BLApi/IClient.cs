using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BO;
namespace BLApi
{
    public interface IClient
    {

        public int Create(Client client);

        public Client Read(int id);

        public List<Client?> ReadAll(Func<Client, bool>? filter = null);

        public void Update(Client Client);
        public void Delete(int id);
        public bool IsCustomerExists(int id);

    }
}
