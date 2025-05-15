using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Subscriptions
{
    public class DomesticSubscription : ISubscription
    {
        public decimal MonthlyFee => 9.99m;
        public int MinimumPeriodMonths => 1;
        public List<string> Channels => new() { "News", "Movies", "Local Sports" };
        public string Features => "Basic streaming in HD";

        public void ShowDetails()
        {
            Console.WriteLine("Domestic Subscription");
            Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriodMonths} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + Features);
        }
    }
}