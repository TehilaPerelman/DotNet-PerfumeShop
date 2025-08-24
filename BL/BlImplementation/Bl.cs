using BLApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlImplementation
{
    internal class Bl : IBl
    {
        public IClient Client => new ClientImplementation();

        public IProduct Product => new ProductImplementation();

        public ISale Sale => new SaleImplementation();

        public IOrder Order => new OrderImplementation();
    }
}
