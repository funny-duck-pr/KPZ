using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Interfaces
{
    public interface IDeviceFactory
    {
        IDevice CreateLaptop();
        IDevice CreateSmartphone();
        IDevice CreateEBook();
        IDevice CreateNetbook();
    }
}