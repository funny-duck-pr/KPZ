using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Lab1_KPZ.Models;


namespace Lab1_KPZ
{

    class Program
    {
        static void Main(string[] args)
        {
            var price = new Money(10, 50);
            var apple = new Product("Apple", "Fruit", "kg", price);
            var warehouse = new Warehouse();
            var report = new Reporting(warehouse);

            report.ReceiveGoods(apple, 100, DateTime.Now);
            report.ShowInventory();

            apple.DecreasePrice(2, 25);
            Console.WriteLine("Price after discount: " + apple);

            report.ShipGoods("Apple", 20);
            report.ShowInventory();
        }
    }
}