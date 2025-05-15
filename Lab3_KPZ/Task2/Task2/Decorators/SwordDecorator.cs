using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Decorators
{
    public class SwordDecorator : InventoryDecorator
    {
        public SwordDecorator(Hero hero) : base(hero) { }

        public override string GetDescription()
        {
            return base.GetDescription() + " Equipped with a sword.";
        }
    }

}