using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace BO
{
    public static class Tools
    {
        public static BO.Client ConvertToBoCustomer(this DO.Client c)
        {

            return new BO.Client(c.id, c.name_client, c.address, c.phone);
        }
        public static DO.Client ConvertToDoCustomer(this BO.Client c)
        {

            return new DO.Client(c.id, c.name_client, c.address, c.phone);
        }
        public static BO.Sale ConvertToBoSale(this DO.Sale s)
        {

            return new BO.Sale(s.id, s.count_sale, s.UniqueId, s.price_sale, s.club ?? false, s.start, s.end);
        }
        public static DO.Sale ConvertToDoSale(this BO.Sale s)
        {

            return new DO.Sale(s.id, s.count_sale, s.UniqueId, s.price_sale, s.club, s.start, s.end);
        }
        public static BO.Product ConvertToBoProduct(this DO.Product p)
        {


            return new BO.Product(p.id, p.ProductName, (BO.perfume)p.category, p.price_product, p.count);
        }
        public static DO.Product ConvertToDoProduct(this BO.Product p)
        {

            return new DO.Product(p.id, p.name_product, (DO.perfume)p.category, p.price_product, p.count);


        }
   
        public static string ToStringProperty<T>(this T obj, string prefix = "")
        {
            StringBuilder sb = new StringBuilder();
            //מעבר על התכונות של האובייקט שהתקבל כפרמטר
            foreach (PropertyInfo prop in obj.GetType().GetProperties())
            {
                if (prop.PropertyType.IsPrimitive
                    || prop.PropertyType == typeof(string)
                    || prop.PropertyType == typeof(DateTime))
                    sb.AppendLine($"{prefix}{prop.Name} = {prop.GetValue(obj)}");
                else
                    sb.Append($"{prefix}{prop.Name} =\n{prop.GetValue(obj).ToStringProperty(prefix + "\t")}");
            }
            return sb.ToString();
        }
    }
}
