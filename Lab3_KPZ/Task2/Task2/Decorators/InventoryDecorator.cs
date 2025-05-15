using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task2.Characters;

namespace Task2.Decorators
{
    public abstract class InventoryDecorator : Hero
    {
        protected Hero _hero;

        public InventoryDecorator(Hero hero)
        {
            _hero = hero;
        }

        public override string GetDescription()
        {
            return _hero.GetDescription();
        }
    }

}