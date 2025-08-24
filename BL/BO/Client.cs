using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public class Client
    {

        public int id { get; set; } = 0;
        public string? name_client { get; set; } = null;
        public string? address { get; set; } = null;
        public string? phone { get; set; } = null;

        public Client()
        {


        }

        public Client(int id, string? name_client, string? address, string? phone)
        {
            this.id = id;
            this.name_client = name_client;
            this.address = address;
            this.phone = phone;
        }
    }
}
