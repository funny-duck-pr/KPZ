using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task5
{
    class Program
    {
        static void Main()
        {
            var director = new Director();

            var hero = director.CreateHero(new HeroBuilder());
            var enemy = director.CreateEnemy(new EnemyBuilder());

            Console.WriteLine("Hero Created:");
            hero.Display();

            Console.WriteLine("Enemy Created:");
            enemy.Display();
        }
    }
}