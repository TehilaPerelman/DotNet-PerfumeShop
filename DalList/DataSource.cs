using DO;

static internal class DataSource
{
    static internal List<Client?> Clients = new List<Client?>();
    static internal List<Product?> products = new List<Product?>();
    static internal List<Sale?> sales = new List<Sale?>();

    internal static class Config
    {
        private static int num = 0;
        public static int GetNump => ++num;
        public static int GetNums => ++num;
    }
}
