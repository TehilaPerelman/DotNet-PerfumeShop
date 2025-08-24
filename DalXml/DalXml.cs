using DalApi;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dal
{
    internal sealed class DalXml : IDal
    {
        private static DalXml instance { get; } = new DalXml();

        public static DalXml Instance
        {
            get
            {
                return instance;
            }
        }

        public IClient Client => new ClientImplementation();

        public IProduct Product => new ProductImplementation();

        public Isale Sale => new SaleImplementation();

        private DalXml()
        {
        }


    }
}
