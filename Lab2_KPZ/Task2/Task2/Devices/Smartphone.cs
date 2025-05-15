using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Devices
{
    public class Smartphone : IDevice
    {
        public string Name { get; }

        public Smartphone(string brand)
        {
            Name = $"{brand} Smartphone";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }
}