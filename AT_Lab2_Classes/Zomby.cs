using System;
using System.Collections.Generic;
using System.Text;

namespace AT_Lab2_Classes
{
    class Zomby : Enemy
    {
        public Zomby(string name, int health, int attack, int armor)

        {
            this.name = name;
            this.health = health;
            this.attack = attack;
            this.armor = armor;
        }
        override public void GetInfo()
        {
            Console.WriteLine($"Зомби  {name}, Здоровье: {health}, Атака: {attack}, Защита: {armor}");
        }
        public static void Motto()
        {
            Console.WriteLine("Девиз победителя-Погибель смертным!");
        }
    }
}
