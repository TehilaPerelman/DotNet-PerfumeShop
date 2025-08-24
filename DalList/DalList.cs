
using DalApi;
using System;

namespace Dal
{
    internal sealed class DalList : IDal
    {

        public static DalList Instance { get; } = new DalList();

        public IProduct Product => new ProductImplementation();
        public Isale Sale => new saleImplementation();
        public IClient Client => new ClientImplementation();
        private DalList()
        {

        }
    }
}
