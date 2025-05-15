using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Interfaces;
using Task2.Devices;

namespace Task2.Factories
{
    public class IProneFactory : IDeviceFactory
    {
        public IDevice CreateLaptop() => new Laptop("IProne");
        public IDevice CreateSmartphone() => new Smartphone("IProne");
        public IDevice CreateEBook() => new EBook("IProne");
        public IDevice CreateNetbook() => new Netbook("IProne");
    }
}