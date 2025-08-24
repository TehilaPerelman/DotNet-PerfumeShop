using BO;
using DalApi;
using DalFacade.DO;
using DalTest;

namespace BlTest;
internal class Program
{
    private static readonly BLApi.IBl s_bl = BLApi.Factory.Get();
    private static void Main(string[] args)
    {
        DalTest.Initialization.Initialize();
        Console.WriteLine("נתוני התחלה הוזנו למערכת.");

        bool shop = true;
        bool shopOrder = true;
        bool isFavorite;
        int amount, prodId;
        BO.Order order;

        while (shop)
        {
            shopOrder = true;
            Console.ForegroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("\nInsert your customer-id, if you don't have any (yet...) press 0");
            Console.ResetColor();
            int customerId;
            if (!int.TryParse(Console.ReadLine(), out customerId))
                customerId = 0;

            try
            {
                isFavorite = (s_bl.Client.Read(customerId)) != null && customerId != 0;
            }
            catch (DalIdNotFoundException ex)
            {
                throw new BlIdNotFoundException("Id Not Found", ex);
            }

            order = new Order(isFavorite);



            while (shopOrder != false)
            {

                Console.WriteLine("\nInsert product id");
                if (!int.TryParse(Console.ReadLine(), out prodId))
                    throw new BlInputNotValidException("Input Not Valid Exception");

                Console.WriteLine("Insert amount");
                if (!int.TryParse(Console.ReadLine(), out amount))
                    throw new BlInputNotValidException("Input Not Valid Exception");

                Console.WriteLine();

                s_bl.Order.AddProductToOrder(order, prodId, amount);
                List<SaleInProduct> salesInProduct = order.ProductsInOrderList.Last().SaleInProduct;
                salesInProduct.ForEach(s => Console.WriteLine(s));

                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("Total Price Till Here: " + order.TotalPrice + "\n");
                Console.ResetColor();

                Console.WriteLine("Continue this order? press a number");
                if (!int.TryParse(Console.ReadLine(), out amount))

                    shopOrder = false;


            }

            s_bl.Order.DoOrder(order);
            Console.WriteLine("Total Price Till Here: " + order.TotalPrice + "\n");

            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine("\nContinue Shopping? press a number");
            if (!int.TryParse(Console.ReadLine(), out amount))
                shop = false;
            Console.ResetColor();
        }


    }
}