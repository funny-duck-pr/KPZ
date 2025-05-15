using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    public class Character
    {
        public string Name { get; set; } = "";
        public string BodyType { get; set; } = "";
        public string HairColor { get; set; } = "";
        public string EyeColor { get; set; } = "";
        public string Outfit { get; set; } = "";
        public List<string> Inventory { get; set; } = new();
        public List<string> Deeds { get; set; } = new();

        public void Display()
        {
            Console.WriteLine($"- Character: {Name}");
            Console.WriteLine($"- Body Type: {BodyType}");
            Console.WriteLine($"- Hair Color: {HairColor}");
            Console.WriteLine($"- Eye Color: {EyeColor}");
            Console.WriteLine($"- Outfit: {Outfit}");
            Console.WriteLine($"- Inventory: {string.Join(", ", Inventory)}");
            Console.WriteLine($"- Deeds: {string.Join(", ", Deeds)}");
            Console.WriteLine();
        }
    }
}