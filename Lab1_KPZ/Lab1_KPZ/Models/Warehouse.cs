using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KPZ.Models
{
    public class WarehouseItem
    {
        public Product Product { get; }
        public int Quantity { get; set; }
        public DateTime LastDeliveryDate { get; set; }

        public WarehouseItem(Product product, int quantity, DateTime deliveryDate)
        {
            Product = product;
            Quantity = quantity;
            LastDeliveryDate = deliveryDate;
        }

        public override string ToString() =>
            $"{Product} | Quantity: {Quantity}, Last delivery: {LastDeliveryDate.ToShortDateString()}";
    }

    public class Warehouse
    {
        private readonly List<WarehouseItem> items = new List<WarehouseItem>();
        public void AddProduct(Product product, int quantity, DateTime date)
        {
            var existing = items.FirstOrDefault(i => i.Product.Name == product.Name);
            if (existing != null)
            {
                existing.Quantity += quantity;
                existing.LastDeliveryDate = date;
            }
            else
            {
                items.Add(new WarehouseItem(product, quantity, date));
            }
        }

        public void ShipProduct(string productName, int quantity)
        {
            var item = items.FirstOrDefault(i => i.Product.Name == productName);
            if (item == null || item.Quantity < quantity)
                throw new InvalidOperationException("Insufficient stock");

            item.Quantity -= quantity;
        }

        public void InventoryReport()
        {
            Console.WriteLine("Inventory Report:");
            foreach (var item in items)
            {
                Console.WriteLine(item);
            }
        }
    }
}