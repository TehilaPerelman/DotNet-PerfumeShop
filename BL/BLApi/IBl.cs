using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface IBl
    {
        public IClient Client { get; }
        public IProduct Product { get; }
        public ISale Sale { get; }
        public IOrder Order { get; }
    }
}
