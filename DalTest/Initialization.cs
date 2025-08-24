using DO;
using DalApi;


namespace DalTest;

public static class Initialization
{
    private static IDal? s_dal;

    private static void CreateProudct()
    {
        s_dal?.Product.Create(new Product(0, " Chanel No. 5", perfume.Oriental, 300, 20));
        s_dal?.Product.Create(new Product(1, "Valentino", perfume.Woody, 500, 24));
        s_dal?.Product.Create(new Product(2, "Tom Ford Black Orchid", perfume.floral, 10, 2000));

    }

    private static void CreateSale()
    {
        s_dal?.Sale.Create(new Sale(0, 1, 1, 100, true, new DateTime(2025, 2, 2), new DateTime(2026, 3, 3)));
        s_dal?.Sale.Create(new Sale(1, 1, 1, 150, true, new DateTime(2025, 2, 2), new DateTime(2026, 3, 3)));
        s_dal?.Sale.Create(new Sale(2, 1, 1, 50, true, new DateTime(2025, 2, 2), new DateTime(2026, 3, 3)));
        s_dal?.Sale.Create(new Sale(3, 1, 1, 250, true, new DateTime(2025, 2, 2), new DateTime(2026, 3, 3)));

    }

    private static void CreateClient()
    {
        s_dal?.Client.Create(new Client(123, "Tehila", "yeuda hanasi 26", "054-8542555"));
        s_dal?.Client.Create(new Client(385, "gili", "kzot 4", "053-419878"));
        s_dal?.Client.Create(new Client(678, "shira", " Yehoda Hanasi 15", "054-2526632"));
    }
    public static void Initialize()
    {
        s_dal = DalApi.Factory.Get;


        CreateClient();
        CreateProudct();
        CreateSale();
    }

}

