using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DalApi
{
    public interface IDal
    {
        public IClient Client { get; }
        public Isale Sale { get; }
        public IProduct Product { get; }

    }
}
