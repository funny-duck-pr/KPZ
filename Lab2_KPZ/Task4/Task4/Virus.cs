using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
{
    public class Virus
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Weight { get; set; }
        public int Age { get; set; }
        public List<Virus> Children { get; set; } = new();

        public Virus(string name, string type, double weight, int age)
        {
            Name = name;
            Type = type;
            Weight = weight;
            Age = age;
        }

        public void AddChild(Virus child)
        {
            Children.Add(child);
        }

        public Virus Clone()
        {
            var clone = new Virus(Name, Type, Weight, Age);
            foreach (var child in Children)
            {
                clone.AddChild(child.Clone());
            }
            return clone;
        }

        public void Print(int indent = 0)
        {
            Console.WriteLine($"{new string(' ', indent)} {Name} ({Type}) - {Weight}kg, {Age} years");
            foreach (var child in Children)
            {
                child.Print(indent + 4);
            }
        }
    }
}