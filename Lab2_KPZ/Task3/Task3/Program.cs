using System;
using System.Threading.Tasks;

namespace Task3
{
    internal class Program
    {
        static void Main()
        {
            Console.WriteLine("Testing Singleton in multiple threads...\n");

            Parallel.For(0, 5, i =>
            {
                var auth = Authenticator.Instance;
                auth.Authenticate($"User{i}");
            });

            Console.WriteLine("\nAll done.");
        }
    }
}