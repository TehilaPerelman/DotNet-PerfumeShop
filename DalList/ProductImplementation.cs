
namespace Dal;
using DO;
using DalApi;
using System;
using DalFacade.DO;
using System.Reflection;
using Tools;

public class ProductImplementation : IProduct
{
    public int Create(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert product in id:{item.id}");

        var newProduct = item with { id = DataSource.Config.GetNump };
        DataSource.products.Add(newProduct);
        return newProduct.id;
    }

    public void Update(Product item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update product in id: {item.id}");

        Delete(item.id);
        DataSource.products.Add(item);
    }

    public Product? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product int id: {id}");

        var p = DataSource.products.FirstOrDefault(p => p.id == id);
        if (p == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found  product in this id: {id}");

            throw new DalIdNotFoundException($"Product with ID  not found");
        }
        return p;
    }
    public Product? Read(Func<Product, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read product");

        var p = DataSource.products.FirstOrDefault(p => filter(p));
        if (p == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found product");

            throw new DalNotFoundException($"Product with ID  not found");
        }
        return p;
    }

   
    public List<Product?> ReadAll(Func<Product, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read all products");

  
        List<Product?> dataSource = DataSource.products;

        if (filter == null)
        {
            return dataSource.Where(item => item != null).ToList();
        }
        else
        {
            return dataSource.Where(item => item != null && filter(item)).ToList();
        }
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"delete product in id:{id}");

        var p = Read(id); 
        DataSource.products.Remove(p);
    }
}
