using System;

namespace Task4
{
    class Program
    {
        static void Main()
        {
            var grandparent = new Virus("Alpha", "Corona", 1.2, 10);

            var parent1 = new Virus("Beta", "Corona", 0.8, 5);
            var parent2 = new Virus("Gamma", "Influenza", 0.9, 4);

            var child1 = new Virus("Delta", "Corona", 0.5, 1);
            var child2 = new Virus("Omicron", "Corona", 0.4, 1);

            parent1.AddChild(child1);
            parent2.AddChild(child2);

            grandparent.AddChild(parent1);
            grandparent.AddChild(parent2);

            Console.WriteLine("Original Virus Family:");
            grandparent.Print();

            var clone = grandparent.Clone();

            Console.WriteLine("\nCloned Virus Family:");
            clone.Print();
        }
    }
}