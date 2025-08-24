
using DalApi;
using DO;
using DalTest;
using System.Data.Common;
using System;
using System.Reflection;
using Tools;


namespace DalTest;
internal class Program
{

    private readonly static IDal s_dal = DalApi.Factory.Get;


    public static int PrintMainMenu()
    {
        Console.WriteLine("For Customers press 1");
        Console.WriteLine("For Products press 2");
        Console.WriteLine("For Sales press 3");
        Console.WriteLine("For Cleaning the Log Directory press 4");
        Console.WriteLine("For Exit press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;

    }

    public static int PrintSubMenu(string item)
    {
        Console.WriteLine($"To add {item} press 1");
        Console.WriteLine($"To read one {item} press 2");
        Console.WriteLine($"To read all {item}s press 3");
        Console.WriteLine($"To update {item} press 4");
        Console.WriteLine($"To delete {item} press 5");
        Console.WriteLine($"To go back press 0");

        int select;
        if (!int.TryParse(Console.ReadLine(), out select))
            select = -1;
        return select;
    }


    public static void CustomerMenu()
    {
        int select;
        select = PrintSubMenu("Customer");
        while (select != 0)
        {
            switch (select)
            {

                case 1:
                    CreateCustomer();
                    break;
                case 2:
                    Read(s_dal.Client);
                    break;
                case 3:
                    ReadAll(s_dal.Client);
                    break;
                case 4:
                    UpdateCustomer();
                    break;
                case 5:
                    Delete(s_dal.Client);
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Customer");
        }

    }


    public static void ProductMenu()
    {
        int select;
        select = PrintSubMenu("Product");
        while (select != 0)
        {
            switch (select)
            {

                case 1:
                    CreateProduct();
                    break;
                case 2:
                    Read(s_dal.Product);
                    break;
                case 3:
                    ReadAll(s_dal.Product);
                    break;
                case 4:
                    UpdateProduct();
                    break;
                case 5:
                    Delete(s_dal.Product);
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Product");
        }

    }


    public static void SaleMenu()
    {
        int select;
        select = PrintSubMenu("Sale");
        while (select != 0)
        {
            switch (select)
            {

                case 1:
                    CreateSale();
                    break;
                case 2:
                    Read(s_dal.Sale);
                    break;
                case 3:
                    ReadAll(s_dal.Sale);
                    break;
                case 4:
                    UpdateSale();
                    break;
                case 5:
                    Delete(s_dal.Sale);
                    break;
                default:
                    Console.WriteLine("Wrong selection. please select again.");
                    break;
            }
            select = PrintSubMenu("Sale");
        }

    }

    public static Product AskProduct(int id = 0)
    {

        string name;
        perfume category;
        int price;
        int count;
        Console.WriteLine("Enter the name of the product");
        name = Console.ReadLine();
        Console.WriteLine("Entet the category: between 0 to 3, Oriental, Woody,floral");
        int cat;
        if (!int.TryParse(Console.ReadLine(), out cat))
            category = 0;
        else
            category = (perfume)cat;
        Console.WriteLine("Enter price");
        if (!int.TryParse(Console.ReadLine(), out price))
            price = 10;
        Console.WriteLine("Enter count in stock");
        if (!int.TryParse(Console.ReadLine(), out count))
            count = 0;
        return new Product(id, name, category, price, count);

    }

    public static Sale AskSale(int id = 0)
    {



        int productId;
        int countForSale;
        int price;
        int select;
        bool forAllCustomers;
        int year;
        int month;
        int day;
        Console.WriteLine("Enter the product id");
        if (!int.TryParse(Console.ReadLine(), out productId))
            productId = 1;

        Console.WriteLine("Enter the required amount");
        if (!int.TryParse(Console.ReadLine(), out countForSale))
            countForSale = 2;
        Console.WriteLine("Enter the including price in the Sale");
        if (!int.TryParse(Console.ReadLine(), out price))
            price = 10;
        Console.WriteLine("Enter if the Sale is for all customets 0/1");
        if (!int.TryParse(Console.ReadLine(), out select))
            forAllCustomers = select == 1;
        forAllCustomers = false;
        Console.WriteLine("Enter the start date of the Sale");

        Console.WriteLine("Enter year");
        if (!int.TryParse(Console.ReadLine(), out year))
            year = 2024;

        Console.WriteLine("Enter month");
        if (!int.TryParse(Console.ReadLine(), out month))
            month = 11;

        Console.WriteLine("Enter day");
        if (!int.TryParse(Console.ReadLine(), out day))
            day = 11;

        DateTime dTStartSale = new DateTime(year, month, day);


        Console.WriteLine("Ente the end date of the Sale");

        Console.WriteLine("Enter year");
        if (!int.TryParse(Console.ReadLine(), out year))
            year = 2024;

        Console.WriteLine("Enter month");
        if (!int.TryParse(Console.ReadLine(), out month))
            month = 11;

        Console.WriteLine("Enter day");
        if (!int.TryParse(Console.ReadLine(), out day))
            day = 11;

        DateTime dTEndSale = new DateTime(year, month, day);


        return new Sale(id, productId, countForSale, price, forAllCustomers, dTStartSale, dTEndSale);




    }

    public static Client AskClient(int id = 0)
    {


        string name;
        string address;
        string phone;
        Console.WriteLine("Enter customer id");
        if (!int.TryParse(Console.ReadLine(), out id))
            id = 123456789;
        Console.WriteLine("Enter customer name");
        name = Console.ReadLine();
        Console.WriteLine("Enter address");
        address = Console.ReadLine();
        Console.WriteLine("Enter phone");
        phone = Console.ReadLine();

        return new Client(id, name, address, phone);
    }

    public static void CreateCustomer()
    {
        try
        {
            Client c = AskClient();
            s_dal.Client.Create(c);
            Console.WriteLine("Customer created successfuly");

        }
        catch (Exception ex)
        {
            //
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }


    }

    public static void CreateProduct()
    {
        try
        {
            Product p = AskProduct();
            int code = s_dal.Product.Create(p);
            p = p with { id = code };
            Console.WriteLine("Product created successfuly");
            Console.WriteLine(p);
        }
        catch (Exception ex)
        {

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }

    }

    public static void CreateSale()
    {
        try
        {

            Sale s = AskSale();
            int code = s_dal.Sale.Create(s);
            s = s with { id = code };
            Console.WriteLine("Sale created successfuly");
            Console.WriteLine(s);
        }
        catch (Exception ex)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }
    }

    public static void UpdateCustomer()
    {

        try
        {
            Client c = AskClient();
            s_dal.Client.Update(c);
            Console.WriteLine("Customer updated successfuly");
        }
        catch (Exception ex)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }
    }

    public static void UpdateSale()
    {
        try
        {
            int id;
            Console.WriteLine("Enter product id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = -1;
            Sale s = AskSale(id);
            s_dal.Sale.Update(s);
            Console.WriteLine("Sale updated successfuly");

        }
        catch (Exception ex)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }
    }

    public static void UpdateProduct()
    {
        try
        {
            int id;
            Console.WriteLine("Enter product id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = -1;

            Product p = AskProduct(id);
            s_dal.Product.Update(p);
            Console.WriteLine("Product updated successfuly");


        }
        catch (Exception ex)
        {

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }
    }

    private static void Read<T>(ICrud<T> crud)
    {
        try
        {

            int id;
            Console.WriteLine($"Insert id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = 1;
            Console.WriteLine(crud.Read(id));

        }
        catch (Exception ex)
        {

            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }
    }

    private static void ReadAll<T>(ICrud<T> crud)
    {
        List<T> item = crud.ReadAll();


        foreach (var i in item)
        {
            Console.WriteLine(i);
            Console.WriteLine();
        }

    }

    private static void Delete<T>(ICrud<T> crud)
    {
        try
        {

            int id;
            Console.WriteLine($"Insert id");
            if (!int.TryParse(Console.ReadLine(), out id))
                id = 1;
            crud.Delete(id);
            Console.WriteLine("Deleted successfuly");


        }
        catch (Exception ex)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, ex.Message);

            Console.WriteLine(ex.Message);
        }

    }


    private static void Main(string[] args)
    {
        Console.WriteLine("Hello, World!");

        try
        {

            Console.WriteLine("Do you want to initialize data? press 1");
            int select;
            if (!int.TryParse(Console.ReadLine(), out select))
                select = 0;
            if (select == 1)
                Initialization.Initialize();


            int select1 = PrintMainMenu();
            while (select1 != 0)
            {
                switch (select1)
                {
                    case 1:
                        Console.WriteLine("Customer");
                        CustomerMenu();
                        break;
                    case 2:
                        Console.WriteLine("Product");
                        ProductMenu();
                        break;
                    case 3:
                        Console.WriteLine("Sale");
                        SaleMenu();
                        break;
                    case 4:
                        Console.WriteLine("Cleaning the Log Directory");
                        LogManager.DeleteLog();
                        break;
                    default:
                        Console.WriteLine("Wrong selection. please select again.");
                        break;
                }
                select1 = PrintMainMenu();

            }
            Console.ReadLine();
        }
        catch (Exception e)
        {
            LogManager.writeToLog(MethodBase.GetCurrentMethod().DeclaringType.FullName, MethodBase.GetCurrentMethod().Name, e.Message);

            Console.WriteLine(e.Message);
        }



    }
}


