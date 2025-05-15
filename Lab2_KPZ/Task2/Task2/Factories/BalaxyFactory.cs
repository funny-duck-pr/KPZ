using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;
using Task2.Devices;

namespace Task2.Factories
{
    public class BalaxyFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Balaxy");
        public IDevice CreateSmartphone() => new Smartphone("Balaxy");
        public IDevice CreateEBook() => new EBook("Balaxy");
        public IDevice CreateNetbook() => new Netbook("Balaxy");
    }
}