using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KPZ.Models
{
    public class Reporting
    {
        private readonly Warehouse warehouse;

        public Reporting(Warehouse warehouse)
        {
            this.warehouse = warehouse;
        }

        public void ReceiveGoods(Product product, int quantity, DateTime date)
        {
            warehouse.AddProduct(product, quantity, date);
            Console.WriteLine($"Received {quantity} {product.Unit} of {product.Name} on {date.ToShortDateString()}");
        }

        public void ShipGoods(string productName, int quantity)
        {
            warehouse.ShipProduct(productName, quantity);
            Console.WriteLine($"Shipped {quantity} of {productName}");
        }

        public void ShowInventory()
        {
            warehouse.InventoryReport();
        }
    }
}