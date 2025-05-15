using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Interfaces
{
    public interface IDevice
    {
        string Name { get; }
        void ShowDetails();
    }
}