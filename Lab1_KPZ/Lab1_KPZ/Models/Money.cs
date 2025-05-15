using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_KPZ.Models
{
    public class Money
    {
        public int WholePart { get; private set; }
        public int FractionalPart { get; private set; }

        public Money(int whole, int fraction)
        {
            SetMoney(whole, fraction);
        }

        public void SetMoney(int whole, int fraction)
        {
            WholePart = whole + fraction / 100;
            FractionalPart = fraction % 100;
        }

        public override string ToString() => $"{WholePart}.{FractionalPart:D2}";
    }
}