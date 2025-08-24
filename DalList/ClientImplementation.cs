
namespace Dal;
using DO;
using DalApi;
using System.Collections.Generic;
using DalFacade.DO;
using System.Reflection;
using Tools;


public class ClientImplementation : IClient
{
    public int Create(Client item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, item.ToString());

        if (DataSource.Clients.Any(c => c?.id == item.id))
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "This customer exists in this id");
            throw new DalIdAlreadyExistsException("Client already exists");
        }

        DataSource.Clients.Add(item);

        return item.id;
    }

    public void Delete(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Id: " + id.ToString());

        Client? curClient = Read(id);

        DataSource.Clients.Remove(curClient);
    }

    public Client? Read(int id)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Id: " + id.ToString());

        Client? curClient = DataSource.Clients.FirstOrDefault(client => client.id == id);

        if (curClient == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, $"Client with ID {id} not found");
            throw new DalIdNotFoundException("Id Not Found In Clients");
        }

        return curClient;
    }

    public Client? Read(Func<Client, bool> filter)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "");

        Client? client = DataSource.Clients.FirstOrDefault(filter);

        if (client == null)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Client not found");
            throw new DalNotFoundException("Client not found");
        }

        return client;
    }

    public List<Client?> ReadAll(Func<Client, bool>? filter = null)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, "Read all customers");

        if (filter == null)
        {
            return DataSource.Clients.Where(item => item != null).ToList();
        }

        return DataSource.Clients.Where(item => item != null && filter(item)).ToList();
    }

    public void Update(Client item)
    {
        LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, item.ToString());

        Delete(item.id);
        DataSource.Clients.Add(item);
    }
}

