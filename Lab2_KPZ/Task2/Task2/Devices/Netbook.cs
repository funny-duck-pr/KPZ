using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Devices
{
    public class Netbook : IDevice
    {
        public string Name { get; }

        public Netbook(string brand)
        {
            Name = $"{brand} Netbook";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }
}