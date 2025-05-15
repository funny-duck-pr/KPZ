using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KPZ.Models
{
    public class Product
    {
        public string Name { get; set; }
        public string Category { get; set; }
        public string Unit { get; set; }
        public Money Price { get; private set; }

        public Product(string name, string category, string unit, Money price)
        {
            Name = name;
            Category = category;
            Unit = unit;
            Price = price;
        }

        public void DecreasePrice(int amount, int cents)
        {
            var totalCents = (Price.WholePart * 100 + Price.FractionalPart) - (amount * 100 + cents);
            if (totalCents < 0) totalCents = 0;
            Price = new Money(totalCents / 100, totalCents % 100);
        }

        public override string ToString() =>
            $"{Name} ({Category}) - {Price} per {Unit}";
    }

}