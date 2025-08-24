using DalApi;
using DalFacade.DO;
using DO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Dal
{
    internal class ClientImplementation : IClient
    {
        private static string filePath = @"../xml/clients.xml";

        const string CUSTOMER = "client";
        const string CUSTOMER_ID = "clientID";
        const string CUSTOMER_NAME = "clientName";
        const string ADDRESS = "Address";
        const string PHONE = "Phone";

        public int Create(Client item)
        {


            XElement file = XElement.Load(filePath);
            XElement customer = file.Descendants(CUSTOMER)
    .FirstOrDefault(c => int.Parse(c.Element(CUSTOMER_ID).Value) == item.id);

            if (customer != null)
                throw new DalIdAlreadyExistsException("Customer Already Exists In Customers");

            file.Add(new XElement(CUSTOMER,
                        new XElement(CUSTOMER_ID, item.id),
                        new XElement(CUSTOMER_NAME, item.name_client),
                        new XElement(ADDRESS, item.address),
                        new XElement(PHONE, item.phone)));

            file.Save(filePath);
            return item.id;


        }

        public Client Read(int id)
        {



            XElement file = XElement.Load(filePath);
            XElement customer = file.Descendants(CUSTOMER).FirstOrDefault(c => int.Parse(c.Element(CUSTOMER_ID).Value) == (id));
            if (customer == null)
                throw new DalIdNotFoundException("Id Not Found In Customers");

            return new Client(int.Parse(customer.Element(CUSTOMER_ID).Value),
                                customer.Element(CUSTOMER_NAME).Value,
                                customer.Element(ADDRESS).Value,
                                customer.Element(PHONE).Value);

        }

        public Client? Read(Func<Client, bool> filter)
        {
            XElement file = XElement.Load(filePath);
            Client customer = ReadAll().FirstOrDefault(filter);

            if (customer == null)
                throw new DalNotFoundException("Customer Not Found In Customers");

            return customer;
        }

        public List<Client?> ReadAll(Func<Client, bool>? filter = null)
        {
            XElement file = XElement.Load(filePath);
            List<Client> customer = file.Descendants(CUSTOMER).Select(c => new Client()
            {
                id = int.Parse(c.Element(CUSTOMER_ID).Value),
                name_client = c.Element(CUSTOMER_NAME).Value,
                address = c.Element(ADDRESS).Value,
                phone = c.Element(PHONE).Value
            }
            ).ToList();

            if (filter == null)
                return customer;

            return customer.Where(filter).ToList();

        }

        public void Update(Client cust)
        {
            XElement file = XElement.Load(filePath);

            Delete(cust.id);

            file.Add(new XElement(CUSTOMER,
                new XElement(CUSTOMER_ID, cust.id),
            new XElement(CUSTOMER_NAME, cust.name_client),
            new XElement(ADDRESS, cust.address),
            new XElement(PHONE, cust.phone)));

            file.Save(filePath);

        }

        public void Delete(int id)
        {
            Read(id);

            XElement file = XElement.Load(filePath);

            file.Descendants(CUSTOMER_ID).FirstOrDefault(x => int.Parse(x.Value) == (id))
            .Parent.Remove();

            file.Save(filePath);
        }
    }



}
