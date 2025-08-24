
using DalApi;
using DalFacade.DO;
using DO;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace Dal
{
    internal class SaleImplementation : Isale
    {
        private static string filePath = @"../xml/sales.xml";
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Sale>));
        private List<Sale> sales = new List<Sale>();

        public int Create(Sale item)
        {
            int index = Config.IndexSaleId;
            sales = ReadAll();
            sales.Add(new Sale(index,
                               item.id,
                               item.count_sale,
                               item.price_sale,
                               item.club,
                               item.start,
                               item.end));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }

            return index;
        }

        public Sale Read(int id)
        {
            sales = ReadAll();
            Sale sale = sales.FirstOrDefault(s => s.UniqueId == id);
            if (sale == null)
                throw new DalIdNotFoundException("Id Not Found In Sales");

            return sale;
        }

        public Sale? Read(Func<Sale, bool> filter)
        {
            sales = ReadAll();
            Sale sale = sales.FirstOrDefault(filter);
            if (sale == null)
                throw new DalNotFoundException("Sale Not Found In Sales");

            return sale;
        }

        public List<Sale> ReadAll(Func<Sale, bool>? filter = null)
        {
            if (File.Exists(filePath))
            {
                using (StreamReader sr = new StreamReader(filePath))
                {
                    sales = serializer.Deserialize(sr) as List<Sale> ?? new List<Sale>();
                }
            }
            else
            {
                sales = new List<Sale>();
            }

            if (filter == null)
                return sales;

            return sales.Where(filter).ToList();
        }

        public void Update(Sale item)
        {
            Delete(item.UniqueId);
            sales = ReadAll();
            sales.Add(new Sale(item.UniqueId,
                               item.id,
                               item.count_sale,
                               item.price_sale,
                               item.club,
                               item.start,
                               item.end));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
        }

        public void Delete(int id)
        {
            Sale curSale = Read(id);
            sales = ReadAll();
            sales.Remove(curSale);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, sales);
            }
        }
    }

}

