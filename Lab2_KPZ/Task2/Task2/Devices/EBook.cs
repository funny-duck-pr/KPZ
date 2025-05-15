using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;

namespace Task2.Devices
{
    public class EBook : IDevice
    {
        public string Name { get; }

        public EBook(string brand)
        {
            Name = $"{brand} E-Book Reader";
        }

        public void ShowDetails()
        {
            Console.WriteLine($"Device: {Name}");
        }
    }
}