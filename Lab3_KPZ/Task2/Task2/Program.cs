using System;
using Task2.Characters;
using Task2.Decorators;

class Program
{
    static void Main()
    {
        Hero warrior = new Warrior("Arthur");
        Hero mage = new Mage("Gandalf");
        Hero palladin = new Palladin("Uther");

        warrior = new ArmourDecorator(warrior);
        warrior = new SwordDecorator(warrior);

        mage = new ArmourDecorator(mage);
        mage = new MagicStaffDecorator(mage);

        palladin = new ArmourDecorator(palladin);
        palladin = new SwordDecorator(palladin);

        Console.WriteLine(warrior.GetDescription());
        Console.WriteLine(mage.GetDescription());
        Console.WriteLine(palladin.GetDescription());
    }
}