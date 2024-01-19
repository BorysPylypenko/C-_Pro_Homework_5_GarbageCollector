using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C__Pro_Homework_5_GarbageCollector
{
    public class Shop : IDisposable
    {
        public string Name { get; set; }
        public string Adres {  get; set; }
        public string Shope_Type { get; set; }

        public Shop(string name, string adres)
        {
            Name = name;
            Adres = adres;
            
        }

        public string Type()
        {
            Console.WriteLine("Enter the type of shop: food, household, clothing, footwear.");
            return  Console.ReadLine();
        }
        public void ShopInfo()
        {
            Console.WriteLine($"Shop: {Name}");
            Console.WriteLine($"Adres: {Adres}");
            Console.WriteLine($"Shop type: {Shope_Type}");
        }

        public void Dispose() 
        {
            Console.WriteLine($"Shop {Name} has been disposed");
        }

        ~Shop() 
        {
            Console.WriteLine($"Finalizer: Shop {Name} has been finalized");
        }



    }
}
