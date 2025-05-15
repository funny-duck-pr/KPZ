using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;
using Task2.Devices;

namespace Task2.Factories
{
    public class KiaomiFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("Kiaomi");
        public IDevice CreateSmartphone() => new Smartphone("Kiaomi");
        public IDevice CreateEBook() => new EBook("Kiaomi");
        public IDevice CreateNetbook() => new Netbook("Kiaomi");
    }
}