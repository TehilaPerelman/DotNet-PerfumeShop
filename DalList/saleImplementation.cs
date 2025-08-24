
namespace Dal;
using DO;
using DalApi;
using System;
using DalFacade.DO;
using System.Reflection;
using Tools;
public class saleImplementation : Isale
{
    public int Create(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"insert Sale in id:{item.id}");

        var newSale = item with { id = DataSource.Config.GetNums };
        DataSource.sales.Add(newSale);
        return newSale.id;
    }

    public void Update(Sale item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"update Sale in id:{item.id}");

        Delete(item.id);
        DataSource.sales.Add(item);
    }

    public Sale? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read Sale int id: {id}");

        var s = DataSource.sales.FirstOrDefault(s => s.id == id);
        if (s == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found  Sale in this id: {id}");

            throw new DalIdNotFoundException($"Sale with ID  not found");
        }
        return s;
    }
    public Sale? Read(Func<Sale, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"read Sale");

        var s = DataSource.sales.FirstOrDefault(s => filter(s));
        if (s == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"not found Sale");

            throw new DalIdNotFoundException($"Sale with ID  not found");
        }
        return s;
    }

    public List<Sale?> ReadAll(Func<Sale, bool>? filter = null)
    {

        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "");

        List<Sale?> result;

        if (filter == null)
        {
            result = new List<Sale?>(DataSource.sales);
        }
        else
        {
            result = DataSource.sales.Where(filter).ToList();
        }

        return result;
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName,
                  MethodBase.GetCurrentMethod().Name, $"delete Sale in id:{id}");
        var s = Read(id);
        DataSource.sales.Remove(s);
    }
}
