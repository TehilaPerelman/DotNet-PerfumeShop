using DalApi;
using DalFacade.DO;
using DO;
using System;
using System.Collections.Generic;
using System.Data.Common;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Dal
{

    internal class ProductImplementation : IProduct
    {
        private static string filePath = @"../xml/products.xml";
        private XmlSerializer serializer = new XmlSerializer(typeof(List<Product>));
        private List<Product> products;

        public int Create(Product item)
        {
            int index = Config.IndexProductId;
            products = ReadAll();
            products.Add(new Product(index,
                                            item.ProductName,
                                            item.category,
                                            item.price_product,
                                            item.count));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }
            return index;
        }

        public Product Read(int id)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {
                products = ReadAll();
                Product product = products.FirstOrDefault(s => s.id == id);
                if (product == null)
                    throw new DalIdNotFoundException("Id Not Found In Products");


                return product;
            }
        }



        public Product? Read(Func<Product, bool> filter)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {
                products = ReadAll();
                Product product = products.FirstOrDefault(filter);
                if (product == null)
                    throw new DalNotFoundException("Product Not Found In Products");

                return product;

            }
        }

        public List<Product?> ReadAll(Func<Product, bool>? filter = null)
        {

            using (StreamReader sr = new StreamReader(filePath))
            {
                products = serializer.Deserialize(sr) as List<Product>;
                if (filter == null)
                    return products;

                return products.Where(filter).ToList();

            }
        }

        public void Update(Product item)
        {

            Delete(item.id);


            products = ReadAll();
            products.Add(new Product(item.id, item.ProductName, item.category, item.price_product, item.count));

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }

        }

        public void Delete(int id)
        {
            Product curProduct = Read(id);
            products = ReadAll();
            products.Remove(curProduct);

            using (StreamWriter sw = new StreamWriter(filePath))
            {
                serializer.Serialize(sw, products);
            }

        }
    }
}
