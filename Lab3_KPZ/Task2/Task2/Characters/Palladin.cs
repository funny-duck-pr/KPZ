using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public class Palladin : Hero
    {
        public Palladin(string name)
        {
            Name = name;
        }

        public override string GetDescription()
        {
            return $"{Name} is a Palladin with holy power and sword.";
        }
    }

}