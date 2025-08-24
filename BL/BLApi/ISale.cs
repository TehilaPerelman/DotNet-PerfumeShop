using BO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BLApi
{
    public interface ISale
    {

        public int Create(Sale sale);
        public Sale Read(int id);
        public Sale? Read(Func<Sale, bool> filter);
        public List<Sale?> ReadAll(Func<Sale, bool>? filter = null);
        public void Update(Sale sale);
        public void Delete(int id);


    }
}
