using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Task1.Interfaces;

namespace Task1.Subscriptions
{
    public class EducationalSubscription : ISubscription
    {
        public decimal MonthlyFee => 7.50m;
        public int MinimumPeriodMonths => 3;
        public List<string> Channels => new() { "Science", "History", "Documentaries" };
        public string Features => "Parental control, no ads";

        public void ShowDetails()
        {
            Console.WriteLine("Educational Subscription");
            Console.WriteLine($"Monthly Fee: ${MonthlyFee}");
            Console.WriteLine($"Minimum Period: {MinimumPeriodMonths} months");
            Console.WriteLine("Channels: " + string.Join(", ", Channels));
            Console.WriteLine("Features: " + Features);
        }
    }
}