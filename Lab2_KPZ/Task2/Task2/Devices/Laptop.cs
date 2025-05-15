using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Devices
{
    public class Laptop : IDevice
    {
        public string Name { get; }

        public Laptop(string brand)
        {
            Name = $"{brand} Laptop";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }
}