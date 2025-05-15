using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public abstract class Hero
    {
        public string Name { get; set; }
        public abstract string GetDescription();
    }

}