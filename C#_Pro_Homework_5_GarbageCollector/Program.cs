

using C__Pro_Homework_5_GarbageCollector;

internal class Program
{
    static void Main()
    {
        using (var novel = new Novel("Ice Warriors", "Red Baykor", "Fantastic", 2015))
        {
            novel.Info();

            Console.ReadLine();
        }
        Console.WriteLine();

        using (var shop = new Shop("MyShop", "123 Main Street"))
        {
            shop.Shope_Type = shop.Type();
            shop.ShopInfo();
            Console.ReadLine();
        }
    }
}