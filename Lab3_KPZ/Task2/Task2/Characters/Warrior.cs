using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2.Characters;

public class Warrior : Hero
{
    public Warrior(string name)
    {
        Name = name;
    }

    public override string GetDescription()
    {
        return $"{Name} is a Warrior with basic armor and sword.";
    }
}