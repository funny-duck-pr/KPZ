using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Subscriptions
{
    public class PremiumSubscription : ISubscription
    {
        public decimal MonthlyFee => 19.99m;
        public int MinimumPeriodMonths => 6;
        public List<string> Channels => new() { "All Access", "4K Sports", "Movies+", "Kids+" };
        public string Features => "Ultra HD, Offline viewing, 4 devices";

        public void ShowDetails()
        {
            Console.WriteLine("Premium Subscription");
            Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriodMonths} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + Features);
        }
    }
}