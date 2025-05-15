using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters
{
    public class Mage : Hero
    {
        public Mage(string name)
        {
            Name = name;
        }

        public override string GetDescription()
        {
            return $"{Name} is a Mage with magic spells.";
        }
    }

}