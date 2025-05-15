using Task2.Factories;
using Task2.Interfaces;

namespace Task2
{
    class Program
    {
        static void Main()
        {
            List<IDeviceFactory> factories = new()
            {
                new IProneFactory(),
                new KiaomiFactory(),
                new BalaxyFactory()
            };

            foreach (var factory in factories)
            {
                Console.WriteLine(factory.GetType().Name);

                IDevice laptop = factory.CreateLaptop();
                IDevice smartphone = factory.CreateSmartphone();
                IDevice ebook = factory.CreateEBook();
                IDevice netbook = factory.CreateNetbook();

                laptop.ShowDetails();
                smartphone.ShowDetails();
                ebook.ShowDetails();
                netbook.ShowDetails();

                Console.WriteLine(new string('-', 40));
            }
        }
    }
}