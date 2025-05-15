using Task1.Creators;
using Task1.Interfaces;

namespace Task1
{
    class Program
    {
        static void Main()
        {
            List<SubscriptionCreator> creators = new()
            {
                new WebSite(),
                new MobileApp(),
                new ManagerCall()
            };

            foreach (var creator in creators)
            {
                ISubscription subscription = creator.CreateSubscription();
                subscription.ShowDetails();
                Console.WriteLine(new string('-', 40));
            }
        }
    }
}